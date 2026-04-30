using Microsoft.Maui.Controls;

namespace SoFit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Start Workout Popup
        private async void OnStartWorkoutClicked(object sender, EventArgs e)
        {
            string result = await DisplayActionSheet("Select Workout Type",
                "Cancel",
                null,
                "🏃 Cardio (30 min)",
                "💪 Strength (45 min)",
                "🧘 Yoga (20 min)",
                "🚴 Cycling (40 min)",
                "🏋️ HIIT (20 min)");

            if (!string.IsNullOrEmpty(result) && result != "Cancel")
            {
                await DisplayAlert("Workout Started", $"Started: {result}\n\nSession tracking has begun!", "OK");
            }
        }

        // Log Activity Popup
        private async void OnLogActivityClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Log Activity", 
                "Activity logged:\n\n" +
                "• Activity: Morning Run\n" +
                "• Duration: 30 minutes\n" +
                "• Calories: 250 burned\n\n" +
                "Great work! Keep it up! 💪",
                "OK");
        }
        // navigation features removed - main page simplified
    }
}
