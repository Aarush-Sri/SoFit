using System.Collections.ObjectModel;
using Sofit.Models;

namespace Sofit.ViewModels;

public class LeaderboardViewModel
{
    public ObservableCollection<User> Users { get; } = new ObservableCollection<User>();

    public LeaderboardViewModel()
    {
        // Sample data
        Users.Add(new User { Name = "Alice", Score = 1200 });
        Users.Add(new User { Name = "Bob", Score = 1100 });
        Users.Add(new User { Name = "Charlie", Score = 900 });
        Users.Add(new User { Name = "Daisy", Score = 800 });
    }
}
