namespace ZetaResourceEditor.UI.Helper;

#region Using directives.
// ----------------------------------------------------------------------

using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

// ----------------------------------------------------------------------
#endregion

/////////////////////////////////////////////////////////////////////////

/// <summary>
/// Control to display information to the user.
/// </summary>
public partial class InformationLightUserControl :
    UserControl
{
    #region Public methods.
    // ------------------------------------------------------------------

    /// <summary>
    ///
    /// </summary>
    public InformationLightUserControl()
    {
        InitializeComponent();
    }

    // ------------------------------------------------------------------
    #endregion

    #region Public properties.
    // ------------------------------------------------------------------

    /// <summary>
    /// 
    /// </summary>
    [DefaultValue( false )]
    public bool UseMouseHoverEffect { get; set; }

    // ------------------------------------------------------------------
    #endregion

    #region Public properties.
    // ------------------------------------------------------------------

    /// <summary>
    /// 
    /// </summary>
    [Localizable( true )]
    public string DescriptionText
    {
        get => descriptionLabel.Text;
        set => descriptionLabel.Text = value;
    }

    // ------------------------------------------------------------------
    #endregion

    #region Private methods.
    // ------------------------------------------------------------------

    /// <summary>
    /// 
    /// </summary>
    private void InvertColors()
    {
        backgroundPanel.BackColor = SystemColors.Highlight;
        descriptionLabel.ForeColor = SystemColors.HighlightText;

        Cursor = Cursors.Hand;
    }

    /// <summary>
    /// 
    /// </summary>
    private void RestoreColors()
    {
        backgroundPanel.BackColor = SystemColors.Info;
        descriptionLabel.ForeColor = SystemColors.InfoText;

        Cursor = Cursors.Default;
    }

    // ------------------------------------------------------------------
    #endregion

    #region Private event handler.
    // ------------------------------------------------------------------

    /// <summary>
    /// 
    /// </summary>
    private void InformationLightUserControl_MouseEnter(
        object sender,
        EventArgs e )
    {
        if ( UseMouseHoverEffect )
        {
            InvertColors();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    private void InformationLightUserControl_MouseLeave(
        object sender,
        EventArgs e )
    {
        RestoreColors();
    }

    /// <summary>
    /// 
    /// </summary>
    private void InformationLightUserControl_Load(
        object sender,
        EventArgs e )
    {
        RestoreColors();
    }

    // ------------------------------------------------------------------
    #endregion

    #region Private variables.
    // ------------------------------------------------------------------

    // ------------------------------------------------------------------
    #endregion
}

/////////////////////////////////////////////////////////////////////////