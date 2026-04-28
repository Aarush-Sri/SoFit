using Microsoft.Maui.Controls;

namespace SoFit
{
    public class BoardPage : ContentPage
    {
        public BoardPage()
        {
            Title = "Board";
            Content = new Label
            {
                Text = "Board page content goes here.",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
        }
    }
}