namespace ZetaResourceEditor.UI.Helper;

internal static class DevExpressExtensionMethods
{
    public static void MakeAutoComplete(
        TextEdit textEdit,
        AutoCompleteMode autoCompleteMode,
        AutoCompleteSource autoCompleteSource)
    {
        // http://community.devexpress.com/forums/p/81601/280039.aspx

        var tx = textEdit.MaskBox;
        tx.AutoCompleteSource = autoCompleteSource;
        tx.AutoCompleteMode = autoCompleteMode;
    }

    public static void MakeAutoComplete(
        ComboBoxEdit comboBoxEdit,
        AutoCompleteMode autoCompleteMode,
        AutoCompleteSource autoCompleteSource)
    {
        // http://community.devexpress.com/forums/p/81601/280039.aspx

        var tx = comboBoxEdit.MaskBox;
        tx.AutoCompleteSource = autoCompleteSource;
        tx.AutoCompleteMode = autoCompleteMode;
    }

    public static void PersistSettings(
        CheckedListBoxControl c,
        IPersistentPairStorage storage,
        string key )
    {
        var indexes = new List<string>();

        for ( var i = 0; i < c.Items.Count; ++i )
        {
            if ( c.GetItemChecked( i ) )
            {
                indexes.Add( i.ToString() );
            }
        }

        PersistanceHelper.SaveValue( storage, key, string.Join( @";", indexes.ToArray() ) );
    }

    public static void RestoreSettings(
        CheckedListBoxControl c,
        IPersistentPairStorage storage,
        string key )
    {
        var indexes = new List<string>();

        for ( var i = 0; i < c.Items.Count; ++i )
        {
            if ( c.GetItemChecked( i ) )
            {
                indexes.Add( i.ToString() );
            }
        }

        var def = string.Join( @";", indexes.ToArray() );

        // --

        var s = PersistanceHelper.RestoreValue(
            storage,
            key,
            def ) as string;

        if ( string.IsNullOrEmpty( s ) )
        {
            for ( var i = 0; i < c.Items.Count; ++i )
            {
                c.SetItemChecked( i, false );
            }
        }
        else
        {
            var splitted = new List<string>( s.Split( ';' ) );

            var ris = new List<int>();
            splitted.ForEach( x => ris.Add( int.Parse( x ) ) );

            for ( var i = 0; i < c.Items.Count; ++i )
            {
                c.SetItemChecked( i, ris.Contains( i ) );
            }
        }
    }

    public static void PersistSettingsByName(
        CheckedListBoxControl c,
        IPersistentPairStorage storage,
        string key )
    {
        var names = new List<string>();

        for ( var i = 0; i < c.Items.Count; ++i )
        {
            if ( c.GetItemChecked( i ) )
            {
                names.Add( c.GetItem(i).ToString() );
            }
        }

        PersistanceHelper.SaveValue( storage, key, string.Join( @"###{{{}}}###", names.ToArray() ) );
    }

    public static void RestoreSettingsByName(
        CheckedListBoxControl c,
        IPersistentPairStorage storage,
        string key )
    {
        var names = new List<string>();

        for ( var i = 0; i < c.Items.Count; ++i )
        {
            if ( c.GetItemChecked( i ) )
            {
                names.Add(c.GetItem(i).ToString());
            }
        }

        var def = string.Join(@"###{{{}}}###", names.ToArray());

        // --

        var s = PersistanceHelper.RestoreValue(
            storage,
            key,
            def ) as string;

        if ( string.IsNullOrEmpty( s ) )
        {
            for ( var i = 0; i < c.Items.Count; ++i )
            {
                c.SetItemChecked( i, false );
            }
        }
        else
        {
            var splitted = new List<string>(s.Split(new[] {@"###{{{}}}###"}, StringSplitOptions.RemoveEmptyEntries));

            var ris = new List<string>(splitted);

            for ( var i = 0; i < c.Items.Count; ++i )
            {
                c.SetItemChecked(i, ris.Contains(c.GetItem(i).ToString()));
            }
        }
    }
}