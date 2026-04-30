using System.Collections.ObjectModel;
using Sofit.Models;

namespace Sofit.ViewModels;

public class SocialViewModel
{
    public ObservableCollection<Post> Posts { get; } = new ObservableCollection<Post>();

    public SocialViewModel()
    {
        Posts.Add(new Post { Author = "Alice", Content = "Great workout today!" });
        Posts.Add(new Post { Author = "Bob", Content = "New PR on squats." });
        Posts.Add(new Post { Author = "Daisy", Content = "New PR on squat." });
    }
}
