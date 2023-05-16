﻿namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomMemoEdit;

using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;

public class MemoEditScrollbarAdjuster
{
	private MemoEdit? _edit;

	public void Attach(MemoEdit? edit)
	{
		_edit = edit;
		if (!DesignModeHelper.IsDesignMode)
		{
			if (_edit != null)
			{
				_edit.SizeChanged += edit_SizeChanged;
				_edit.TextChanged += edit_TextChanged;
			}

			adjustScrollbars();
		}
	}

	public void Detach()
	{
		if (!DesignModeHelper.IsDesignMode && _edit != null)
		{
			_edit.SizeChanged -= edit_SizeChanged;
			_edit.TextChanged -= edit_TextChanged;
		}
	}

	private void edit_SizeChanged(object? sender, EventArgs e)
	{
		if (!DesignModeHelper.IsDesignMode)
		{
			adjustScrollbars();
		}
	}

	private void edit_TextChanged(object? sender, EventArgs e)
	{
		if (!DesignModeHelper.IsDesignMode)
		{
			adjustScrollbars();
		}
	}

	private void adjustScrollbars()
	{
		// Hide scrollbar when not needed.
		// http://devexpress.com/Support/Center/p/Q96633.aspx

		// Looking for a Windows Forms solution?
		// http://stackoverflow.com/questions/73110/how-can-i-show-scrollbars-on-a-system-windows-forms-textbox-only-when-the-text-d

		var vi = (MemoEditViewInfo?)_edit?.GetViewInfo();
		using var cache = new GraphicsCache(_edit?.CreateGraphics());
		var h = ((IHeightAdaptable?)vi)?.CalcHeight(
			cache,
			vi.MaskBoxRect.Width) ?? 0;

		var args = new ObjectInfoArgs
		{
			Bounds = new(0, 0, vi?.ClientRect.Width ?? 0, h)
		};

		var rect = vi.BorderPainter.CalcBoundsByClientRectangle(args);
		if (_edit != null)
		{
			_edit.Properties.ScrollBars =
				rect.Height > _edit.Height
					? ScrollBars.Vertical
					: ScrollBars.None;
		}
	}

}