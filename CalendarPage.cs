using Microsoft.Maui.Controls;

namespace SoFit
{
    public class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            Title = "Calendar";
            Content = new Label
            {
                Text = "Calendar page content goes here.",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
        }
    }
}