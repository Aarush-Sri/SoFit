using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Sofit;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { });

        // Register pages and viewmodels for simple DI
        builder.Services.AddTransient<Views.LeaderboardPage>();
        builder.Services.AddTransient<Views.SocialPage>();
        builder.Services.AddTransient<Views.SplitSchedulePage>();
        builder.Services.AddTransient<Views.CalendarTrackerPage>();

        builder.Services.AddSingleton<ViewModels.LeaderboardViewModel>();
        builder.Services.AddSingleton<ViewModels.SocialViewModel>();
        builder.Services.AddSingleton<ViewModels.SplitScheduleViewModel>();
        builder.Services.AddSingleton<ViewModels.CalendarTrackerViewModel>();

        return builder.Build();
    }
}