using System;
using System.Web.UI.WebControls;
using Zeta.EnterpriseLibrary.Logging;
using System.ComponentModel;

public class PageBase :
	Zeta.EnterpriseLibrary.Web.Base.PageBase
{
	private PageLoadTaskPerformer _loadTaskPerformer;

	[DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden ), 
	Localizable( true ), 
	Bindable( true )]
	public string Title2
	{
		get
		{
			return ViewState[@"Title2"] as string;
		}
		set
		{
			ViewState[@"Title2"] = value;
		}
	}

	[DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden ), 
	Localizable( true ), 
	Bindable( true )]
	public string Title3
	{
		get
		{
			return ViewState[@"Title3"] as string;
		}
		set
		{
			ViewState[@"Title3"] = value;
		}
	}

	public PageLoadTaskPerformer LoadTaskPerformer
	{
		get
		{
			if ( _loadTaskPerformer == null )
			{
				_loadTaskPerformer = new PageLoadTaskPerformer( this );
			}

			return _loadTaskPerformer;
		}
	}

	protected override void OnLoad( EventArgs e )
	{
		if ( !IsPostBack )
		{
			if ( LoadTaskPerformer.PerformTasks() )
			{
				LogCentral.Current.LogDebug(
					string.Format(
					@"PageBase.OnLoad(): Performed task, redirecting to '{0}'.",
					LoadTaskPerformer.RedirectUrl ) );

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
				if ( string.Compare( item.Value, value, true ) == 0 )
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