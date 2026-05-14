using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SoFit.Models;

namespace SoFit.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private UserProfile _user;

    public MainViewModel()
    {
        // Initial dummy data
        User = new UserProfile
        {
            Name = "Alex",
            Calories = 750,
            Steps = 8432,
            Progress = 0.65
        };
    }

    [RelayCommand]
    private void StartWorkout()
    {
        // This code runs when you click the button
        User.Calories += 50;
        User.Steps += 100;

        // Notify the UI that data changed
        OnPropertyChanged(nameof(User));
    }
}