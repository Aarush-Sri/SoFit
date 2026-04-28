using Microsoft.Maui.Controls;

namespace SoFit
{
    public class SplitPage : ContentPage
    {
        public SplitPage()
        {
            Title = "Split";
            Content = new Label
            {
                Text = "Split page content goes here.",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
        }
    }
}