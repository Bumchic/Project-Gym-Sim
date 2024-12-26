using Avalonia.Controls;
using ProjectGymSim.GamePartView;

namespace ProjectGymSim;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        GameView gameView = new GameView();
        gameView.Show();
    }
}