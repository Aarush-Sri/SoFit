using SoFit.ViewModels;

namespace SoFit;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        // This connects the UI to the brain we just built
        BindingContext = new MainViewModel();
    }
}