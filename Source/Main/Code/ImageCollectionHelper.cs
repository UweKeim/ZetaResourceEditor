namespace ZetaResourceEditor.Code;

using Properties;
using RuntimeBusinessLogic.FileGroups;

/// <summary>
/// Weil DX Probleme mit ImageCollection hat, das jetzt erst mal selber machen:
/// https://supportcenter.devexpress.com/ticket/details/t1094636/bad-image-format
/// </summary>
internal static class ImageCollectionHelper
{
	private static byte[]? _update1;
	private static byte[]? _update2;
	private static byte[]? _edit;
	private static byte[]? _file;
	private static byte[]? _group;
	private static byte[]? _projectfolder;
	private static byte[]? _root;

	public static byte[] Update1 => _update1 ??= ImageResources.update_1;
	public static byte[] Update2 => _update2 ??= ImageResources.update_2;
	public static byte[] Edit => _edit ??= ImageResources.edit;
	public static byte[] File => _file ??= ImageResources.file;
	public static byte[] Group => _group ??= ImageResources.group;
	public static byte[] ProjectFolder => _projectfolder ??= ImageResources.projectfolder;
	public static byte[] Root => _root ??= ImageResources.root;

	private static ImageCollection? _ic16;
	private static SvgImageCollection? _icSvg;

	public static ImageCollection Ic16
	{
		get
		{
			if (_ic16 == null)
			{
				_ic16 = new()
				{
					ImageSize = new(16, 16)
				};

				_ic16.Images.Add(ImageResources.color_grey_16, FileGroupStateColor.Grey.ToString());
				_ic16.Images.Add(ImageResources.color_green_16, FileGroupStateColor.Green.ToString());
				_ic16.Images.Add(ImageResources.color_yellow_16, FileGroupStateColor.Yellow.ToString());
				_ic16.Images.Add(ImageResources.color_red_16, FileGroupStateColor.Red.ToString());
				_ic16.Images.Add(ImageResources.color_blue_16, FileGroupStateColor.Blue.ToString());
			}

			return _ic16;
		}
	}

	public static SvgImageCollection IcSvg
	{
		get
		{
			if (_icSvg == null)
			{
				_icSvg = new()
				{
					{ @"root", Root },
					{ @"group", Group },
					{ @"file", File },
					{ @"projectfolder", ProjectFolder },
					{ @"edit", Edit }
				};
			}

			return _icSvg;
		}
	}

	public static int IndexOfKey(this SvgImageCollection col, string key)
	{
		var i = 0;
		foreach (var k in col.Keys)
		{
			if (k == key)
				return i;
			i++;
		}

		return -1;
	}
}