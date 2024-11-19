using System.Collections.ObjectModel;
using SfBugReports.Data;

namespace SfBugReports;

public partial class FilterFailOnObjectCollection
{
    public FilterFailOnObjectCollection()
    {
        InitializeComponent();
    }

    public ObservableCollection<object> DemoData { get; } = [
        new Horse("Carl", "Andalusian", 3),
        new Horse("Majesty", "Oldenburg", 5),
        new Horse("Meadow", "Shetland", 9),
    ];
}