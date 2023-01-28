namespace ZetaResourceEditor.Code;

using Properties;
using RuntimeBusinessLogic.FileGroups;

/// <summary>
/// Weil DX Probleme mit ImageCollection hat, das jetzt erst mal selber machen:
/// https://supportcenter.devexpress.com/ticket/details/t1094636/bad-image-format
/// </summary>
internal static class ImageCollectionHelper
{
    private static ImageCollection _ic16;
    private static ImageCollection _ic32;

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

                _ic16.Images.Add(ImageResources.root_16, @"root");
                _ic16.Images.Add(ImageResources.root_16, @"project");
                _ic16.Images.Add(ImageResources.group_16, @"group");
                _ic16.Images.Add(ImageResources.group_16, @"filegroup");
                _ic16.Images.Add(ImageResources.file_16, @"file");
                _ic16.Images.Add(ImageResources.projectfolder_16, @"projectfolder");
                _ic16.Images.Add(ImageResources.file_16, @"document.png");
                _ic16.Images.Add(ImageResources.note_16, @"note.png");

                _ic16.Images.Add(ImageResources.color_grey_16, FileGroupStateColor.Grey.ToString());
                _ic16.Images.Add(ImageResources.color_green_16, FileGroupStateColor.Green.ToString());
                _ic16.Images.Add(ImageResources.color_yellow_16, FileGroupStateColor.Yellow.ToString());
                _ic16.Images.Add(ImageResources.color_red_16, FileGroupStateColor.Red.ToString());
                _ic16.Images.Add(ImageResources.color_blue_16, FileGroupStateColor.Blue.ToString());

                Ic16.Images.Add(ImageResources.edit_16, @"box_edit.png");
            }

            return _ic16;
        }
    }

    public static ImageCollection Ic32
    {
        get
        {
            if (_ic32 == null)
            {
                _ic32 = new()
                {
                    ImageSize = new(32, 32)
                };

                _ic32.Images.Add(ImageResources.update_1_32, @"heart-1");
                _ic32.Images.Add(ImageResources.update_2_32, @"heart-2");
            }

            return _ic32;
        }
    }
}