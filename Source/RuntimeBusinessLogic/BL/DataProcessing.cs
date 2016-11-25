namespace ZetaResourceEditor.RuntimeBusinessLogic.BL
{
    #region Using directives.
    // ----------------------------------------------------------------------

    using DL;
    using FileGroups;
    using Language;
    using Projects;
    using Properties;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.IO;
    using System.Text;
    using System.Xml;
    using Zeta.VoyagerLibrary.Common;
    using ZetaLongPaths;

    // ----------------------------------------------------------------------
    #endregion

    /////////////////////////////////////////////////////////////////////////

    public sealed class DataProcessing
    {
        #region Private variables.
        // ------------------------------------------------------------------

        private List<ResxFile> _resxFiles;
        private readonly IGridEditableData _gridEditableData;
        private readonly object _backupLock = new object();

        public static event AskOverwriteDelegate<ZlpFileInfo> CanOverwrite;

        // ------------------------------------------------------------------
        #endregion

        #region Private methods.
        // ------------------------------------------------------------------

        /// <summary>
        /// Load files from FileSystem
        /// </summary>
        private void loadFiles()
        {
            _resxFiles = new List<ResxFile>();

            foreach (var item in _gridEditableData.GetFileInformationsSorted())
            {
                using (var reader = XmlReader.Create(item.File.FullName))
                {
                    var doc = new XmlDocument();
                    doc.Load(reader);
                    doc.Normalize();

                    _resxFiles.Add(
                        new ResxFile
                        {
                            FileInformation = item,
                            FilePath = item.File,
                            Document = doc
                        });
                }
            }
        }

        /// <summary>
        /// Store files to FileSystem
        /// </summary>
        private void storeFiles(Project project)
        {
            foreach (var resxFile in _resxFiles)
            {
                if (resxFile.FilePath.Exists)
                {
                    if ((ZlpIOHelper.GetFileAttributes(resxFile.FilePath.FullName) &
                        ZetaLongPaths.Native.FileAttributes.Readonly) != 0)
                    {
                        if (_gridEditableData?.Project != null)
                        {
                            switch (_gridEditableData.Project.ReadOnlyFileOverwriteBehaviour)
                            {
                                case ReadOnlyFileOverwriteBehaviour.Overwrite:
                                    // Simply continue to code below.
                                    break;
                                case ReadOnlyFileOverwriteBehaviour.Ask:
                                    var h = CanOverwrite;
                                    resxFile.FilePath.Refresh();
                                    switch (h(resxFile.FilePath))
                                    {
                                        case AskOverwriteResult.Overwrite:
                                            // Simply continue to code below.
                                            break;
                                        case AskOverwriteResult.Skip:
                                            continue;
                                        case AskOverwriteResult.Fail:
                                            throw new Exception(
                                                string.Format(
                                                    Resources.SR_DataProcessing_storeFiles_Save_operation_was_cancelled_at_file,
                                                    resxFile.FilePath.Name));

                                        default:
                                            throw new ArgumentOutOfRangeException();
                                    }
                                    break;
                                case ReadOnlyFileOverwriteBehaviour.Skip:
                                    continue;
                                case ReadOnlyFileOverwriteBehaviour.Fail:
                                    throw new Exception(
                                        string.Format(
                                            Resources.SR_DataProcessing_storeFiles_Saving_failed_because_of_read_only_file,
                                            resxFile.FilePath.Name));

                                default:
                                    throw new ArgumentOutOfRangeException();
                            }
                        }
                    }

                    removeReadOnlyAttributes(resxFile.FilePath);
                    ZlpSafeFileOperations.SafeDeleteFile(resxFile.FilePath.FullName);
                }

                var settings =
                    new XmlWriterSettings
                    {
                        Indent = true,
                        IndentChars = project.ResXIndentChar,
                        Encoding = Encoding.UTF8
                    };

                using (var sw = new StreamWriter(
                    resxFile.FilePath.FullName,
                    false,
                    new UTF8Encoding(false)))
                using (var write = XmlWriter.Create(sw, settings))
                {
                    var doc = resxFile.Document;
                    doc.Save(write);
                }
            }
        }

        public static bool GetShowCommentColumn(Project project)
        {
            return project != null && project.ShowCommentsColumnInGrid;
        }

        // AJ CHANGE
        // Checks if the Column Comment is visible in the row
        public static bool CommentsAreVisible(
            Project project,
            DataTable table,
            CommentVisibilityScope commentVisibilityScope)
        {
            if (commentVisibilityScope == CommentVisibilityScope.InMemory || GetShowCommentColumn(project))
            {
                var colName = table.Columns[table.Columns.Count - 1].ColumnName;

                // Sometimes the comment column gets the prefix col, depends on the visibility state
                return colName == @"colComment" ||
                       colName == @"Comment" ||
                       colName == @"col" + Resources.SR_ColumnCaption_Comment ||
                       colName == @"col" + Resources.SR_CommandProcessorSend_Process_Comment ||
                       colName == Resources.SR_ColumnCaption_Comment;
            }
            else
            {
                return false;
            }
        }

        public static bool CommentsAreVisible(
            Project project,
            DataRow row,
            CommentVisibilityScope commentVisibilityScope)
        {
            return CommentsAreVisible(project, row.Table, commentVisibilityScope);
        }

        public static string GetComment(
            Project project,
            DataRow row)
        {
            if (CommentsAreVisible(project, row, CommentVisibilityScope.InMemory))
            {
                return row[row.Table.Columns.Count - 1] as string;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Create the data table for the grid.
        /// </summary>
        private DataTable getTable(
            Project project,
            bool forceCommentColumn)
        {
            // Load File from filesystem
            loadFiles();

            var table = new DataTable();

            // Add primary key columns.
            table.Columns.Add(
                new DataColumn
                {
                    ColumnName = @"FileGroup",
                    Caption = Resources.SR_ColumnCaption_FileGroup,
                });
            table.Columns.Add(
                new DataColumn
                {
                    ColumnName = @"Name",
                    Caption = Resources.SR_ColumnCaption_Name,
                });
            table.PrimaryKey =
                new[]
                    {
                        table.Columns[@"FileGroup"],
                        table.Columns[@"Name"]
                    };

            // AJ CHANGE

            // Add a Column for each filename
            foreach (var resxFile in _resxFiles)
            {
                var cn = resxFile.FilePath.Name;

                var culture =
                    new LanguageCodeDetection(
                        _gridEditableData.Project)
                        .DetectCultureFromFileName(
                            _gridEditableData.ParentSettings,
                            cn);

                var cultureCaption =
                    $@"{culture.DisplayName} ({culture.Name})";

                //Member 802361: only file names are loaded if same culture is not added first. there are no references any more to other files with same culture. So we name each column by culture and not by file name.
                //TODO: please check if no side effects elsewere
                if (!containsCaption(table.Columns, cultureCaption))
                {
                    var column =
                        new DataColumn(culture.Name)
                        {
                            Caption = cultureCaption
                        };
                    table.Columns.Add(column);
                }
            }

            if (GetShowCommentColumn(project) || forceCommentColumn)
            {
                table.Columns.Add(
                    new DataColumn
                    {
                        ColumnName = @"Comment",
                        Caption = Resources.SR_ColumnCaption_Comment
                    });
            }

            // --

            // Add rows and fill them with data
            foreach (var resxFile in _resxFiles)
            {
                var fgcs = resxFile.FileInformation.FileGroup.GetChecksum(project);
                var cn = resxFile.FilePath.Name;

                var culture =
                    new LanguageCodeDetection(
                        _gridEditableData.Project)
                        .DetectCultureFromFileName(
                            _gridEditableData.ParentSettings,
                            cn);

                var cultureCaption =
                    $@"{culture.DisplayName} ({culture.Name})";

                var doc = resxFile.Document;
                var data = doc.GetElementsByTagName(@"data");

                var captionIndexCache = new Dictionary<string, int>();

                // Each "data" node of the XML document is processed
                foreach (XmlNode node in data)
                {
                    var process = true;

                    //Check if this is a non string data tag
                    if (node.Attributes != null && node.Attributes[@"type"] != null)
                    {
                        process = false;
                    }

                    //skip mimetype like application/x-microsoft.net.object.binary.base64
                    // http://www.codeproject.com/KB/aspnet/ZetaResourceEditor.aspx?msg=3367544#xx3367544xx
                    if (node.Attributes != null && node.Attributes[@"mimetype"] != null)
                    {
                        process = false;
                    }

                    if (process)
                    {
                        // Get value of the "name" attribute
                        // and look for it in the datatable
                        var name = node.Attributes == null ? string.Empty : node.Attributes[@"name"].Value;
                        var row = table.Rows.Find(new object[] { fgcs, name });

                        // Fixes the "value of second file displayed in first column" bug_.
                        if (row == null)
                        {
                            table.Rows.Add(fgcs, name);
                            row = table.Rows.Find(new object[] { fgcs, name });

                            // AJ CHANGE
                            if (GetShowCommentColumn(project) || forceCommentColumn)
                            {
                                var comment = node.SelectSingleNode(@"comment");
                                if (comment != null)
                                {
                                    row[@"Comment"] =
                                        string.IsNullOrEmpty(comment.InnerText)
                                            ? string.Empty
                                            : AdjustLineBreaks(comment.InnerText);
                                    row.AcceptChanges();
                                }
                            }
                        }

                        var value = node.SelectSingleNode(@"value");

                        if (value != null)
                        {
                            setAtCultureCaption(
                                captionIndexCache,
                                table.Columns,
                                row,
                                cultureCaption,
                                string.IsNullOrEmpty(value.InnerText)
                                    ? string.Empty
                                    : AdjustLineBreaks(value.InnerText));
                            row.AcceptChanges();
                        }
                    }
                }
            }

            return table;
        }

        public static string ExtractCultureNameFromColumnCaption(
            string caption)
        {
            var li = caption.LastIndexOf('(');
            var ri = caption.LastIndexOf(')');

            if (li <= 0 || ri < li)
            {
                return null;
            }
            else
            {
                return caption.Substring(li + 1, ri - li - 1);
            }
        }

        private static bool containsCaption(
            DataColumnCollection columns,
            string cultureCaption)
        {
            // ReSharper disable LoopCanBeConvertedToQuery
            foreach (DataColumn column in columns)
            // ReSharper restore LoopCanBeConvertedToQuery
            {
                if (string.Compare(column.Caption, cultureCaption, true) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static void setAtCultureCaption(
            IDictionary<string, int> captionIndexCache,
            DataColumnCollection columns,
            DataRow row,
            string cultureCaption,
            string text)
        {
            int columnIndex;
            if (captionIndexCache.TryGetValue(cultureCaption, out columnIndex))
            {
                row[columnIndex] = text;
            }
            else
            {
                var index = 0;
                foreach (DataColumn dataColumn in columns)
                {
                    if (index > 1) // Column 0=FileGroup checksum, column 1=Tag name.
                    {
                        if (string.Compare(dataColumn.Caption, cultureCaption, true) == 0)
                        {
                            captionIndexCache[cultureCaption] = index;

                            row[index] = text;
                            return;
                        }
                    }

                    index++;
                }
            }
        }

        public static string AdjustLineBreaks(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }
            else
            {
                // ReSharper disable LocalizableElement
                text = text.Replace("\r\n", "\n");
                text = text.Replace("\r", "\n");
                text = text.Replace("\n", Environment.NewLine);
                // ReSharper restore LocalizableElement

                return text;
            }
        }

        /// <summary>
        /// Store the changes in the data table back to the .RESX files
        /// </summary>
        private void saveTable(
            Project project,
            DataTable table,
            bool wantBackupFiles,
            bool omitEmptyStrings)
        {
            var index = 0;
            var languageCodeDetection = new LanguageCodeDetection(_gridEditableData.Project);

            foreach (var resxFile in _resxFiles)
            {
                try
                {
                    var checksum = resxFile.FileInformation.FileGroup.GetChecksum(project);
                    var document = resxFile.Document;
                    var fileName = resxFile.FilePath.Name;

                    //Member 802361: access value by culture and not by filename
                    var culture =
                        languageCodeDetection.DetectLanguageCodeFromFileName(
                            _gridEditableData.Project,
                            fileName);

                    // 2011-04-09, Uwe Keim: "nb" => "nb-NO".
                    var cultureLong = LanguageCodeDetection.MakeValidCulture(culture).Name;

                    foreach (DataRow row in table.Rows)
                    {
                        if (row.RowState != DataRowState.Deleted)
                        {
                            if (!FileGroup.IsInternalRow(row))
                            {
                                var fileGroupCheckSum = ConvertHelper.ToInt64(row[@"FileGroup"]);

                                // 2010-10-23, Uwe Keim: Only save if same file group.
                                if (fileGroupCheckSum == checksum)
                                {
                                    var tagName = (string)row[@"Name"];

                                    var xpathQuery = $@"child::data[attribute::name='{escapeXsltChars(tagName)}']";

                                    if (document.DocumentElement != null)
                                    {
                                        var node = document.DocumentElement.SelectSingleNode(xpathQuery);
                                        var found = node != null;

                                        var content = row[cultureLong] as string;
                                        var textToSet = content ?? string.Empty;

                                        var commentsAreVisible =
                                            CommentsAreVisible(project, row, CommentVisibilityScope.InMemory);

                                        // AJ CHANGE
                                        var commentToSet =
                                            commentsAreVisible
                                                ? row[@"Comment"] == DBNull.Value
                                                    ? string.Empty
                                                    : (string)row[@"Comment"]
                                                : null;

                                        if (found)
                                        {
                                            var n = node.SelectSingleNode(@"value");

                                            //CHANGED: 	Member 802361 if content is null remove this entry
                                            if (content != null &&
                                                (!string.IsNullOrEmpty(textToSet) || !omitEmptyStrings))
                                            {
                                                // If not present (for whatever reason, e.g.
                                                // manually edited and therefore misformed).
                                                if (n == null)
                                                {
                                                    n = document.CreateElement(@"value");
                                                    node.AppendChild(n);
                                                }

                                                n.InnerText = textToSet;

                                                // AJ CHANGE
                                                // Only write the comment to the main resx file
                                                if (commentsAreVisible)
                                                {
                                                    if (resxFile == _resxFiles[0])
                                                    {
                                                        n = node.SelectSingleNode(@"comment");
                                                        // If not present (for whatever reason, e.g.
                                                        // manually edited and therefore misformed).
                                                        if (n == null)
                                                        {
                                                            n = document.CreateElement(@"comment");
                                                            node.AppendChild(n);
                                                        }

                                                        n.InnerText = commentToSet ?? string.Empty;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (n != null)
                                                {
                                                    node.RemoveChild(n);
                                                }

                                                if (node.ParentNode != null)
                                                {
                                                    node.ParentNode.RemoveChild(node);
                                                }
                                            }
                                        }
                                        else // Resource doesn't exist in XML.
                                        {
                                            if (content != null &&
                                                (!string.IsNullOrEmpty(textToSet) || !omitEmptyStrings))
                                            {
                                                // Member 802361: only do it if editing single fileGroup.
                                                // If no we don't know where to add the new entry.
                                                // TODO: may be add to default file in the list?
                                                if (_gridEditableData.FileGroup == null)
                                                {
                                                    //look if base file has same tagName
                                                    //if base file skip it
                                                    if (string.Compare(
                                                        _gridEditableData.Project.NeutralLanguageCode,
                                                        culture,
                                                        StringComparison.OrdinalIgnoreCase) == 0 ||
                                                        string.Compare(
                                                            _gridEditableData.Project.NeutralLanguageCode,
                                                            cultureLong,
                                                            StringComparison.OrdinalIgnoreCase) == 0)
                                                    {
                                                        continue;
                                                    }

                                                    // 2011-01-26, Uwe Keim:
                                                    var pattern =
                                                        resxFile.FileInformation.FileGroup.ParentSettings.EffectiveNeutralLanguageFileNamePattern;
                                                    pattern = pattern.Replace(@"[basename]", resxFile.FileInformation.FileGroup.BaseName);
                                                    pattern = pattern.Replace(@"[languagecode]", project.NeutralLanguageCode);
                                                    pattern = pattern.Replace(@"[extension]", resxFile.FileInformation.FileGroup.BaseExtension);
                                                    pattern = pattern.Replace(@"[optionaldefaulttypes]",
                                                                              resxFile.FileInformation.FileGroup.BaseOptionalDefaultType);

                                                    //has base culture value?
                                                    var baseName = pattern;

                                                    // 2011-01-26, Uwe Keim:
                                                    var file = resxFile;
                                                    var baseResxFile =
                                                        _resxFiles.Find(
                                                            resx =>
                                                            resx.FilePath.Name == baseName &&
                                                            resx.FileInformation.FileGroup.UniqueID ==
                                                            file.FileInformation.FileGroup.UniqueID);
                                                    if (baseResxFile == null ||
                                                        baseResxFile.Document == null ||
                                                        baseResxFile.Document.DocumentElement == null)
                                                    {
                                                        continue;
                                                    }

                                                    var baseNode =
                                                        baseResxFile.Document.DocumentElement.
                                                            SelectSingleNode(xpathQuery);
                                                    if (null == baseNode)
                                                    {
                                                        continue;
                                                    }
                                                    //ok we can add it.
                                                }
                                                //TODO: use default instead

                                                //Create the new Node
                                                XmlNode newData = document.CreateElement(@"data");
                                                var newName = document.CreateAttribute(@"name");
                                                var newSpace = document.CreateAttribute(@"xml:space");
                                                XmlNode newValue = document.CreateElement(@"value");

                                                // Set the Values
                                                newName.Value = (string)row[@"Name"];
                                                newSpace.Value = @"preserve";
                                                newValue.InnerText = textToSet;

                                                // Get them together
                                                if (newData.Attributes != null)
                                                {
                                                    newData.Attributes.Append(newName);
                                                    newData.Attributes.Append(newSpace);
                                                }
                                                newData.AppendChild(newValue);

                                                // AJ CHANGE
                                                // Only write the comment to the main resx file
                                                if (commentsAreVisible && index == 0)
                                                {
                                                    XmlNode newComment = document.CreateElement(@"comment");
                                                    newComment.InnerText = commentToSet ?? string.Empty;
                                                    newData.AppendChild(newComment);
                                                }

                                                XmlNode root = document.DocumentElement;
                                                root?.InsertAfter(newData, root.LastChild);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                finally
                {
                    index++;
                }
            }

            if (wantBackupFiles)
            {
                backupFiles();
            }

            // Store files back to filesystem
            storeFiles(project);
        }

        private static string escapeXsltChars(
            string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return query;
            }
            else
            {
                return query.
                   Replace(@"'", @"&acute;").
                   Replace(@"""", @"&quot;");
            }
        }

        private void backupFiles()
        {
            lock (_backupLock)
            {
                foreach (var resxFile in _resxFiles)
                {
                    var bak = resxFile.FilePath;

                    // Delete old bak files
                    if (ZlpIOHelper.FileExists(bak.FullName + @".bak"))
                    {
                        // Remove ReadOnly-attribute.
                        removeReadOnlyAttributes(
                            new ZlpFileInfo(bak.FullName + @".bak"));
                        ZlpSafeFileOperations.SafeDeleteFile(bak + @".bak");
                    }

                    ZlpSafeFileOperations.SafeCopyFile(
                        resxFile.FilePath.FullName,
                        bak.FullName + @".bak",
                        true);
                }
            }
        }

        private static void removeReadOnlyAttributes(
            ZlpFileInfo path)
        {
            ZlpIOHelper.SetFileAttributes(
                path.FullName,
                path.Attributes & ~ZetaLongPaths.Native.FileAttributes.Readonly);
        }

        private void rename(
            string oldName,
            string newName)
        {
            foreach (var resxFile in _resxFiles)
            {
                var tmp = resxFile.Document;

                var xpathQuery = $@"child::data[attribute::name='{escapeXsltChars(oldName)}']";

                if (tmp.DocumentElement != null)
                {
                    var target =
                        tmp.DocumentElement.SelectSingleNode(
                            xpathQuery);

                    // Can be NULL if not yet written.
                    // http://www.codeproject.com/Messages/3107527/Re-more-bugs.aspx
                    if (target != null && target.Attributes != null)
                    {
                        target.Attributes[@"name"].Value = newName;
                    }
                }
            }
        }

        /// <summary>
        /// Adds the specified tag.
        /// </summary>
        private void add(
            string tag)
        {
            foreach (var resxFile in _resxFiles)
            {
                var tmp = resxFile.Document;

                XmlNode newData = tmp.CreateElement(@"data");
                var newName = tmp.CreateAttribute(@"name");
                var newSpace = tmp.CreateAttribute(@"xml:space");
                XmlNode newValue = tmp.CreateElement(@"value");

                // Set the Values
                newName.Value = tag;
                newSpace.Value = @"preserve";
                newValue.InnerText = string.Empty;

                // Get them together
                if (newData.Attributes != null)
                {
                    newData.Attributes.Append(newName);
                    newData.Attributes.Append(newSpace);
                }
                newData.AppendChild(newValue);

                XmlNode root = tmp.DocumentElement;

                if (root != null)
                {
                    root.InsertAfter(
                        newData,
                        root.LastChild);
                }
            }
        }

        /// <summary>
        /// Deletes the specified tag.
        /// </summary>
        private void delete(
            string tag)
        {
            foreach (var resxFile in _resxFiles)
            {
                var tmp = resxFile.Document;

                var xpathQuery =
                    $@"child::data[attribute::name='{escapeXsltChars(tag)}']";

                if (tmp.DocumentElement != null)
                {
                    var target = tmp.DocumentElement.SelectSingleNode(
                        xpathQuery);

                    if (target != null)
                    {
                        tmp.DocumentElement.RemoveChild(target);
                    }
                }
            }
        }

        // ------------------------------------------------------------------
        #endregion

        #region Public methods.
        // ------------------------------------------------------------------

        public DataProcessing(
            IGridEditableData gridEditableData)
        {
            _gridEditableData = gridEditableData;
        }

        /// <summary>
        /// Creates the data source for the grid as "<see cref="DataTable"/>".
        /// </summary>
        public DataTable GetDataTableFromResxFiles(
            Project project)
        {
            return GetDataTableFromResxFiles(project, false);
        }

        public DataTable GetDataTableFromResxFiles(
            Project project,
            bool forceCommentColumn)
        {
            return getTable(project, forceCommentColumn);
        }

        /// <summary>
        /// Stores the changes made in the grid back to the .RESX files
        /// </summary>
        public void SaveDataTableToResxFiles(
            Project project,
            DataTable table)
        {
            var createBackups = project != null && project.CreateBackupFiles;
            var omitEmptyStrings = project != null && project.OmitEmptyItems;

            SaveDataTableToResxFiles(project, table, createBackups, omitEmptyStrings);
        }

        /// <summary>
        /// Stores the changes made in the grid back to the .RESX files
        /// </summary>
        public void SaveDataTableToResxFiles(
            Project project,
            DataTable table,
            bool backupFiles,
            bool omitEmptyStrings)
        {
            saveTable(project, table, backupFiles, omitEmptyStrings);
        }

        /// <summary>
        /// Rename existing tag
        /// </summary>
        public void RenameTag(
            string oldName,
            string newName)
        {
            rename(oldName, newName);
        }

        /// <summary>
        /// Delete existing tag
        /// </summary>
        public void DeleteTag(
            string tag)
        {
            delete(tag);
        }

        /// <summary>
        /// Add new tag
        /// </summary>
        public void AddTag(
            string tag)
        {
            add(tag);
        }

        // ------------------------------------------------------------------
        #endregion
    }

    /////////////////////////////////////////////////////////////////////////
}