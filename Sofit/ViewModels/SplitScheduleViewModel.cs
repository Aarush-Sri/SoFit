using System.Collections.ObjectModel;
using Sofit.Models;

namespace Sofit.ViewModels;

public class SplitScheduleViewModel
{
    public ObservableCollection<Split> Splits { get; } = new ObservableCollection<Split>();

    public SplitScheduleViewModel()
    {
        Splits.Add(new Split { Name = "Push Day", Description = "Chest, Shoulders, Triceps" });
        Splits.Add(new Split { Name = "Pull Day", Description = "Back, Biceps" });
        Splits.Add(new Split { Name = "Leg Day", Description = "Quads, Hamstrings, Calves" });
    }
}
