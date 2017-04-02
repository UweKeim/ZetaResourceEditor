using System;
using System.ComponentModel;
using System.Web.UI.WebControls;
using Zeta.VoyagerLibrary.Logging;

namespace Web.Code.Base
{
    public class PageBase :
        Zeta.VoyagerLibrary.WebForms.Base.PageBase
    {
        private PageLoadTaskPerformer _loadTaskPerformer;

        [DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden ), 
         Localizable( true ), 
         Bindable( true )]
        public string Title2
        {
            get => ViewState[@"Title2"] as string;
            set => ViewState[@"Title2"] = value;
        }

        [DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden ), 
         Localizable( true ), 
         Bindable( true )]
        public string Title3
        {
            get => ViewState[@"Title3"] as string;
            set => ViewState[@"Title3"] = value;
        }

        public PageLoadTaskPerformer LoadTaskPerformer => _loadTaskPerformer ?? (_loadTaskPerformer = new PageLoadTaskPerformer(this));

        protected override void OnLoad( EventArgs e )
        {
            if ( !IsPostBack )
            {
                if ( LoadTaskPerformer.PerformTasks() )
                {
                    LogCentral.Current.Info(@"PageBase.OnLoad(): Performed task, redirecting to '{0}'.", LoadTaskPerformer.RedirectUrl);

                    LoadTaskPerformer.Redirect();
                }
            }

            base.OnLoad( e );
        }

        public static void SelectDropDownValue( DropDownList dd, string value )
        {
            if ( string.IsNullOrEmpty( value ) )
            {
                dd.SelectedIndex = -1;
            }
            else
            {
                var index = 0;
                foreach ( ListItem item in dd.Items )
                {
                    if ( string.Compare( item.Value, value, StringComparison.OrdinalIgnoreCase ) == 0 )
                    {
                        dd.SelectedIndex = index;
                        return;
                    }

                    index++;
                }

                // Not found.
                dd.SelectedIndex = -1;
            }
        }
    }
}