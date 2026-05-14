using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace SoFit
{
    public partial class SplitPage : ContentPage
    {
        public ObservableCollection<WorkoutSplit> Splits { get; set; } = new ObservableCollection<WorkoutSplit>();

        public SplitPage()
        {
            InitializeComponent();

            Splits.Add(new WorkoutSplit { Name = "Push/Pull/Legs", Description = "3-day split focusing on compound movements." });
            Splits.Add(new WorkoutSplit { Name = "Upper/Lower", Description = "Alternate upper and lower body sessions." });
            Splits.Add(new WorkoutSplit { Name = "Full Body", Description = "Entire body each session for frequency." });
            Splits.Add(new WorkoutSplit { Name = "PPL Advanced", Description = "6-day push/pull/legs with added volume." });

            SplitsCollection.ItemsSource = Splits;
        }

        private async void OnCreateCustomSplitClicked(object sender, System.EventArgs e)
        {
            string name = await DisplayPromptAsync("New Split", "Enter a name for your custom split:");
            if (string.IsNullOrWhiteSpace(name))
                return;

            string desc = await DisplayPromptAsync("Description", "Enter a short description (optional):");

            Splits.Add(new WorkoutSplit { Name = name, Description = desc ?? string.Empty });
        }
    }

    public class WorkoutSplit
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
