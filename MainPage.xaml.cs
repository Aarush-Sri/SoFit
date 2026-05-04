using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace SoFit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Goal Details Popup
        private async void OnGoalDetailsClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Today's Goal details",
                "🎯 Daily Goal Information\n\n" +
                "1000 calories - Cardio focused\n" +
                "Target: 10,000 steps\n" +
                "Goal: 2 workouts minimum\n\n" +
                "Progress: 75% complete",
                "Close");
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
        // Navigation - Home
        private async void OnNavHomeClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Home", "You are already on the Home page", "OK");
        }

        // Navigation - Split (opens SplitPage)
        private async void OnNavSplitClicked(object sender, EventArgs e)
        {
            // Navigate to SplitPage if navigation is available
            if (this.Navigation != null)
            {
                await Navigation.PushAsync(new SplitPage());
            }
            else
            {
                await DisplayAlert("Split", "Could not navigate to Split page.", "OK");
            }
        }

        // Navigation - Board (Stats/Analytics)
        private async void OnNavBoardClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Analytics Board",
                "📊 Your Statistics:\n\n" +
                "This Week:\n" +
                "  • Workouts: 3\n" +
                "  • Total Duration: 2h 15m\n" +
                "  • Calories Burned: 2,250\n\n" +
                "This Month:\n" +
                "  • Workouts: 12\n" +
                "  • Total Duration: 9h 30m\n" +
                "  • Calories Burned: 8,500",
                "Close");
        }

        // Navigation - Calendar
        private async void OnNavCalendarClicked(object sender, EventArgs e)
        {
            string result = await DisplayActionSheet("Calendar",
                "Cancel",
                null,
                "View Monthly Calendar",
                "View Weekly Schedule",
                "Schedule Workout",
                "View Completed Workouts");

            if (!string.IsNullOrEmpty(result) && result != "Cancel")
            {
                await DisplayAlert("Calendar", result, "OK");
            }
        }

        // Navigation - Settings
        private async void OnNavSettingsClicked(object sender, EventArgs e)
        {
            string result = await DisplayActionSheet("Settings",
                "Cancel",
                null,
                "⚙️ General Settings",
                "👤 Profile",
                "🔔 Notifications",
                "📊 Data & Privacy",
                "ℹ️ About SoFit");

            if (!string.IsNullOrEmpty(result) && result != "Cancel")
            {
                if (result.Contains("General"))
                {
                    await DisplayAlert("General Settings",
                        "• Theme: Dark Mode\n" +
                        "• Units: Metric (kg, km)\n" +
                        "• Language: English",
                        "OK");
                }
                else if (result.Contains("Profile"))
                {
                    await DisplayAlert("Profile",
                        "Name: Alex\n" +
                        "Age: 28\n" +
                        "Height: 6'0\"\n" +
                        "Weight: 185 lbs\n" +
                        "Goal: Build Muscle",
                        "OK");
                }
                else if (result.Contains("Notifications"))
                {
                    await DisplayAlert("Notifications",
                        "✓ Workout Reminders: ON\n" +
                        "✓ Daily Motivation: ON\n" +
                        "✓ Goal Achievements: ON\n" +
                        "✓ Weekly Summary: ON",
                        "OK");
                }
                else if (result.Contains("Data"))
                {
                    await DisplayAlert("Data & Privacy",
                        "Your data is securely stored.\n\n" +
                        "Last Backup: Today\n" +
                        "Storage Used: 45 MB",
                        "OK");
                }
                else if (result.Contains("About"))
                {
                    await DisplayAlert("About SoFit",
                        "SoFit v1.0.0\n" +
                        "Your Complete Fitness Companion\n\n" +
                        "© 2024 SoFit Inc.\n" +
                        "Made with ❤️ for fitness enthusiasts",
                        "OK");
                }
            }
        }
    }
}
