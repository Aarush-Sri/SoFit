using System.Collections.ObjectModel;
using Sofit.Models;
using System;

namespace Sofit.ViewModels;

public class CalendarTrackerViewModel
{
    public ObservableCollection<CalendarEntry> Entries { get; } = new ObservableCollection<CalendarEntry>();

    public CalendarTrackerViewModel()
    {
        Entries.Add(new CalendarEntry { Date = DateTime.Today, Notes = "Leg day: squats and lunges" });
        Entries.Add(new CalendarEntry { Date = DateTime.Today.AddDays(-1), Notes = "Push day: bench and press" });
    }
}
