namespace ZetaResourceEditor.UI.Main.RightContent;

using DevExpress.Accessibility;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

public class RtlMemoEdit :
    MemoEdit
{
    public override RightToLeft RightToLeft
    {
        get => RightToLeft.Yes;
// ReSharper disable ValueParameterNotUsed
        set
// ReSharper restore ValueParameterNotUsed
            => base.RightToLeft = RightToLeft.Yes;
    }
}

public class RtlMemoEditViewInfo :
    MemoEditViewInfo
{
    public RtlMemoEditViewInfo(RepositoryItem item)
        : base(item)
    {
    }
}

public class RtlMemoEditPainter :
    MemoEditPainter
{
    /// <summary>
    /// Copied, because was originally internal.
    /// </summary>
    internal bool IsTextMatch(
        TextEditViewInfo viewInfo, 
        out int containsIndex, 
        out int matchedLength)
    {
        containsIndex = 0;
        var text = viewInfo.DisplayText.ToLower();
        var matched = viewInfo.MatchedString.ToLower();
        matchedLength = matched.Length;

        if (text == matched)
        {
            return true;
        }
        if (BaseEdit.StringStartsWidth(text, matched))
        {
            return true;
        }

        if (viewInfo.MatchedStringUseContains)
        {
            containsIndex = text.IndexOf(matched, StringComparison.Ordinal);
            if (containsIndex > -1)
            {
                return true;
            }
        }

        if (viewInfo.MatchedStringAllowPartial)
        {
            for (; matchedLength > 0; matchedLength--)
            {
                matched = matched.Substring(0, matchedLength);
                if (BaseEdit.StringStartsWidth(text, matched))
                {
                    return true;
                }
                if (viewInfo.MatchedStringUseContains)
                {
                    containsIndex = text.IndexOf(matched, StringComparison.Ordinal);
                    if (containsIndex > -1)
                    {
                        return true;
                    }
                }
            }
        }

        containsIndex = -1;
        return false;
    }

    /// <summary>
    /// Copied, because was originally internal.
    /// </summary>
    internal bool CheckDrawMatchedText(ControlGraphicsInfoArgs info)
    {
        var vi = (TextEditViewInfo)info.ViewInfo;
        var r = vi.MaskBoxRect;

        if (vi.MatchedString.Length > 0)
        {
            var matchedText = vi.MatchedString;
            if (IsTextMatch(vi, out var containsIndex, out var matchedLength))
            {
                matchedText = matchedText.Substring(0, matchedLength);
                if (!vi.MatchedStringUseContains)
                {
                    containsIndex = -1;
                }

                DrawMatchedString(
                    info,
                    r,
                    vi.DisplayText,
                    matchedText,
                    vi.PaintAppearance,
                    vi.IsInvertIncrementalSearchString,
                    containsIndex);

                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    protected override void DrawText(ControlGraphicsInfoArgs info)
    {
        var vi = (TextEditViewInfo)info.ViewInfo;
        if (vi.AllowDrawText)
        {
            if (!BaseEditViewInfo.ShowFieldBindings || 
                string.IsNullOrEmpty(vi.GetDataBindingText()))
            {
                var r = vi.MaskBoxRect;
                if (!CheckDrawMatchedText(info))
                {
                    var sf = vi.PaintAppearance.GetStringFormat(vi.DefaultTextOptions);
                    var newSf = new StringFormat(sf);

                    // TODO: Not yet perfect.

                    newSf.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
                    newSf.Alignment = StringAlignment.Far;

                    var text = /*'\x202E' +*/ vi.DisplayText;

                    info.Cache.DrawString(
                        text,
                        vi.PaintAppearance.Font,
                        vi.PaintAppearance.GetForeBrush(info.Cache),
                        r,
                        newSf);
                }
            }
        }
    }
}

public class RtlMemoEditAccessible :
    MemoEditAccessible
{
    public RtlMemoEditAccessible(RepositoryItem item)
        : base(item)
    {
    }
}

public class RtlRepositoryItemMemoEdit :
    RepositoryItemMemoEdit
{
    static RtlRepositoryItemMemoEdit()
    {
        RegisterRtlMemoEdit();
    }

    private static void RegisterRtlMemoEdit()
    {
        var editorInfo =
            new EditorClassInfo(
                nameof(RtlMemoEdit),
                typeof(RtlMemoEdit),
                typeof(RtlRepositoryItemMemoEdit),
                typeof(RtlMemoEditViewInfo),
                new RtlMemoEditPainter(),
                true,
                EditImageIndexes.MemoEdit,
                typeof(RtlMemoEditAccessible));

        EditorRegistrationInfo.Default.Editors.Add(editorInfo);
    }

    public override string EditorTypeName => @"RtlMemoEdit";
}