using System.Collections.ObjectModel;

namespace RadAutocompleteTest;

public partial class WorkAroundOne : ContentPage
{
    public ObservableCollection<TestItem> TestItems =
       [
           new TestItem { Libelle = "Test A" },
            new TestItem { Libelle = "Test B"},
            new TestItem { Libelle = "Test C"},
            new TestItem { Libelle = "Test D"},
            new TestItem { Libelle = "Test E"},
            new TestItem { Libelle = "Test F"},
            new TestItem { Libelle = "Test G"},
            new TestItem { Libelle = "Test H"},
            new TestItem { Libelle = "Test I"},
            new TestItem { Libelle = "Test J"},
            new TestItem { Libelle = "Test K"},
            new TestItem { Libelle = "Test L"},
            new TestItem { Libelle = "Test M"}
       ];

    public WorkAroundOne()
    {
        InitializeComponent();

        RadAutoComplete.ItemsSource = TestItems;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void RadAutoComplete_Focused(object sender, FocusEventArgs e)
    {
        RadAutoComplete?.ShowSuggestions();
    }

    /// <summary>
    /// Fill autocomplete when item selected
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        RadAutoComplete?.Text = e?.CurrentSelection?.FirstOrDefault() is TestItem item ? item.Libelle : string.Empty;

        if (!string.IsNullOrEmpty(RadAutoComplete?.Text))
            RadAutoComplete?.Unfocus();
    }
}