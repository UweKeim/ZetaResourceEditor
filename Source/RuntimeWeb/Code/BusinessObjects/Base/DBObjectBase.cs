namespace ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects.Base
{
	using System;
	using System.Data;
	using System.Diagnostics;
	using System.Text.RegularExpressions;
	using Sys;
	using Zeta.EnterpriseLibrary.Data;
	using Zeta.EnterpriseLibrary.Tools;

	[DebuggerDisplay(@"ID = {_id}, Type = ""{GetType()}""")]
	public abstract class DBObjectBase
	{
		private object _tag;

		#region Formatting.
		// ------------------------------------------------------------------

		/// <summary>
		/// How a summary is generated.
		/// </summary>
		public enum SummaryType
		{
			/// <summary>
			/// Text mode, breaks as "\r\n".
			/// </summary>
			Text,

			/// <summary>
			/// HTML mode, breaks as &lt;br /&gt;.
			/// </summary>
			Html
		}

		/// <summary>
		/// Remove blank lines from a string.
		/// </summary>
		public static string EliminateMultipleBlanks(
			string s,
			SummaryType type)
		{
			s = s.Trim();

			s = s.Replace("\r\n", "\n");
			s = s.Replace("\r", "\n");

			s = Regex.Replace(
				s,
				"\\n[ \\t]*\\n",
				"\n",
				RegexOptions.IgnoreCase);

			if (type == SummaryType.Html)
			{
				s = HtmlHelper.FormatMultiLine(s);
			}

			return s;
		}

		// ------------------------------------------------------------------
		#endregion

		/// <summary>
		/// Remove blank lines from a string.
		/// </summary>
		public static string EliminateMultipleBlanks(
			string s)
		{
			s = s.Trim();

			s = s.Replace("\r\n", "\n");
			s = s.Replace("\r", "\n");

			s = Regex.Replace(
				s,
				"\\n[ \\t]*\\n",
				"\n",
				RegexOptions.IgnoreCase);

			return s;
		}

		/// <summary>
		/// Indicates whether the object does exist in the database or
		/// in memory only (i.e. is still unsaved).
		/// </summary>
		public virtual bool IsEmpty
		{
			get
			{
				return _id <= 0;
			}
		}

		public object Tag
		{
			get
			{
				return _tag;
			}
			set
			{
				_tag = value;
			}
		}

		public string DBTag
		{
			get
			{
				return _dbTag;
			}
			set
			{
				_dbTag = value;
			}
		}

		public bool IsDeleted
		{
			get
			{
				return _isDeleted;
			}
			set
			{
				_isDeleted = value;
			}
		}

		/// <summary>
		/// The owning manager of this object.
		/// </summary>
		public DBObjectsManagerBase OwningManager
		{
			get
			{
				return _owningManager;
			}
			set
			{
				_owningManager = value;
			}
		}

		/// <summary>
		/// The owning manager of this object.
		/// </summary>
		public ElementManager ElementManager
		{
			get
			{
				return _owningManager.ElementManager;
			}
		}

		/// <summary>
		/// Gets the ID.
		/// </summary>
		/// <value>The ID.</value>
		public virtual int ID
		{
			get
			{
				return _id;
			}
		}

		/// <summary>
		/// Determines whether [is null or empty] [the specified obj].
		/// </summary>
		/// <param name="obj">The obj.</param>
		/// <returns>
		/// 	<c>true</c> if [is null or empty] [the specified obj]; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsNullOrEmpty(
			DBObjectBase obj)
		{
			return obj == null || obj.IsEmpty;
		}

		public static bool IsEmptyID(
			int id)
		{
			return id <= 0;
		}

		public void StoreIfEmpty()
		{
			if (IsEmpty)
			{
				Store();
			}
		}

		public bool CanStore
		{
			get
			{
				return IsValid;
			}
		}

		public bool IsValid
		{
			get
			{
				try
				{
					Validate();
					return true;
				}
				catch (ValidationException)
				{
					return false;
				}
			}
		}

		/// <summary>
		/// Stores this instance.
		/// </summary>
		public virtual void Store()
		{
		}

		/// <summary>
		/// Deletes the specified options.
		/// </summary>
		public virtual void Delete()
		{
			ResetID();
		}

		/// <summary>
		/// Throws if invalid.
		/// </summary>
		public virtual void Validate(
			ValidateObjectDelegate del)
		{
			if (del != null)
			{
				del(this);
			}
		}

		/// <summary>
		/// Loads the specified row.
		/// </summary>
		/// <param name="row">The row.</param>
		public virtual void Load(
			DataRow row)
		{
			if (row != null)
			{
				var columns = row.Table.Columns;

				if (columns.Contains(@"ID"))
				{
					DBHelper.ReadField(out _id, row[@"ID"]);
				}

				if (columns.Contains(@"IsDeleted"))
				{
					DBHelper.ReadField(out _isDeleted, row[@"IsDeleted"]);
				}

				if (columns.Contains(@"DBTag"))
				{
					DBHelper.ReadField(out _dbTag, row[@"DBTag"]);
				}
			}
		}

		/// <summary>
		/// Stores the specified row.
		/// </summary>
		/// <param name="row">The row.</param>
		protected virtual void Store(
			DataRow row)
		{
			if (row != null)
			{
				var columns = row.Table.Columns;

				if (columns.Contains(@"IsDeleted"))
				{
					row[@"IsDeleted"] = DBHelper.WriteField(_isDeleted);
				}

				if (columns.Contains(@"DBTag"))
				{
					row[@"DBTag"] = DBHelper.WriteField(_dbTag);
				}
			}
		}

		/// <summary>
		/// Throws if invalid.
		/// </summary>
		public void Validate()
		{
			if (ValidateObject != null)
			{
				var args = new ValidateObjectEventArgs(this);
				ValidateObject.Raise(this, args);
			}
		}

		public readonly FastSmartWeakEvent<EventHandler<ValidateObjectEventArgs>> ValidateObject =
			new FastSmartWeakEvent<EventHandler<ValidateObjectEventArgs>>();

		protected int _id;
		private DBObjectsManagerBase _owningManager;
		private bool _isDeleted;
		private string _dbTag;

		/// <summary>
		/// Resets the ID.
		/// </summary>
		public void ResetID()
		{
			_id = 0;
		}

		/// <summary>
		/// Copies from the given object.
		/// </summary>
		/// <param name="source">The source object to copy from.</param>
		public virtual void CopyFrom(
			DBObjectBase source)
		{
			// Condition added 2008-11-15, Uwe Keim.
			// Only set if not already set to allow copying between
			// different projects.
			if (_owningManager == null)
			{
				_owningManager = source._owningManager;
			}

			_id = source._id;
			_tag = source._tag;
		}

		/// <summary>
		/// Throw a <see cref="ValidationException"/> if not valid.
		/// </summary>
		public delegate void ValidateObjectDelegate(
			DBObjectBase obj);

		public class ValidateObjectEventArgs :
			EventArgs
		{
			private readonly DBObjectBase _obj;

			public ValidateObjectEventArgs(DBObjectBase obj)
			{
				_obj = obj;
			}

			public DBObjectBase Obj
			{
				get
				{
					return _obj;
				}
			}
		}
	}
}