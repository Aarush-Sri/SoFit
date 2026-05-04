using Microsoft.Maui.Controls;

namespace SoFit
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private async void OnThemeToggled(object sender, ToggledEventArgs e)
        {
            bool isDark = e.Value;
            // For now, just show confirmation
            await DisplayAlert("Theme", isDark ? "Dark theme enabled" : "Light theme enabled", "OK");
        }

        private async void OnNotificationsToggled(object sender, ToggledEventArgs e)
        {
            await DisplayAlert("Notifications", "Notification settings updated", "OK");
        }

        private async void OnBackupClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Backup", "Backup completed successfully.", "OK");
        }

        private async void OnResetClicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("Reset Data", "Are you sure you want to reset all app data?", "Yes", "No");
            if (confirm)
            {
                await DisplayAlert("Reset", "Data has been reset.", "OK");
            }
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            // Ideally save to local settings - simplified here
            await DisplayAlert("Settings", "Settings saved.", "OK");
        }
    }
}
