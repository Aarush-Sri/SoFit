namespace SoFit.Models;

public class UserProfile
{
    public string Name { get; set; } = "Alex";
    public int Calories { get; set; }
    public int Steps { get; set; }
    public double Progress { get; set; } // Represented as 0.0 to 1.0
}