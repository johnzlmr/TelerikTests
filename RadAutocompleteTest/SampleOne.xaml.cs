using System.Collections.ObjectModel;

namespace RadAutocompleteTest;

public partial class SampleOne : ContentPage
{
    private ObservableCollection<string> _rawTestItems =
           [
           "Raw Test A",
        "Raw Test B",
        "Raw Test C",
        "Raw Test D",
        "Raw Test E",
        "Raw Test F",
        "Raw Test G",
        "Raw Test H",
        "Raw Test I",
        "Raw Test J",
        "Raw Test K",
        "Raw Test L",
        "Raw Test M",
        ];
    public ObservableCollection<string> RawTestItems
    {
        get { return _rawTestItems; }
        set { }
    }

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

    public SampleOne()
    {
        InitializeComponent();

        RadAutoComplete.ItemsSource = TestItems;
    }

    private void RadAutoComplete_Focused(object sender, FocusEventArgs e)
    {
        RadAutoComplete?.ShowSuggestions();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}

public record TestItem()
{
    public string Code { get; set; } = string.Empty;
    public string Libelle { get; set; } = string.Empty;
}