using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Threading.Tasks;

namespace ProjectGymSim.GamePartView;

public partial class GameView : Window
{
    public static int DelayTime { get; set; } = 1000;
    public double Progress { get; set; }
    private const double UpperLim = 100.0;
    private const double LowerLim = 0.0;
    
    public GameView()
    {
        InitializeComponent();
        Progress = UpperLim;
        this.ProgressBar.Value = UpperLim;
        DecreaseProgress();
    }

    public void DecreaseProgress()
    {
        while (this.Progress > LowerLim)
        {
            Progress = Progress - 0.5;
            this.ProgressBar.Value = Progress;
            Console.WriteLine(Progress);
            Task.Delay(DelayTime).Wait();
        }
        this.Title = Progress.ToString();
    }
}