using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Threading.Tasks;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace ProjectGymSim.GamePartView;

public partial class GameView : Window
{
    public double Progress { get; set; }
    private const double UpperLim = 100.0;
    private const double LowerLim = 0.0;
    public Action decrease;
    public int Difficulty{get;set;}
    public GameView()
    {
        InitializeComponent();
    }

    public GameView(int difficulty) : this()
    {
        this.Difficulty = difficulty;
        Progress = 50;
        this.ProgressBar.Value = Progress;
 
    }

    public void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Task.Run(DecreaseProgress);
    }

    public void DecreaseProgress()
    {
        while (this.Progress > LowerLim)
        {
            Progress = Progress - 1;
            this.ProgressBar.Value = Progress;
            Console.WriteLine(Progress);
            Task.Delay(1000).Wait();
        }
    }
    public async void SpaceButton_OnKeyDown(object? sender, KeyEventArgs e)
    {
        if (e.Key != Key.Space)
        {
            Console.WriteLine("Space");
            return;
        }
        this.Progress += 3;
        this.ProgressBar.Value = Progress;
    }
}