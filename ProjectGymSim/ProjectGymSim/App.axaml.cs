using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ProjectGymSim.GamePartView;

namespace ProjectGymSim;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {


        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            GameView gameView = new GameView(3);
            desktop.MainWindow = gameView;

        }
        base.OnFrameworkInitializationCompleted();

    }
}