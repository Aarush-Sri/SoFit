using Microsoft.Maui.Controls;

namespace SoFit
{
    public class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            Title = "Settings";
            Content = new Label
            {
                Text = "Settings page content goes here.",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
        }
    }
}