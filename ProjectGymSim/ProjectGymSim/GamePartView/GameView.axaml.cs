using System;
using System.Threading;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Threading.Tasks;
using Avalonia.Input;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Avalonia.Media.Imaging;

namespace ProjectGymSim.GamePartView;

public partial class GameView : Window
{
    public double Progress { get; set; }
    private const double UpperLim = 100.0;
    private const double LowerLim = 0.0;
    private double PressProgress;
    public int Difficulty{get;set;}
    List<Image> GameFrame = new List<Image>();
    private Task BarTimer;
    private Task AddProgress;
    
    public GameView()
    {
        InitializeComponent();
    }

    public GameView(int difficulty) : this()
    {

        this.Difficulty = difficulty;
        Progress = 50;
        PressProgress = 0;
        BarTimer = new Task(() =>
        {
            while (this.Progress > LowerLim)
            {
                Progress--;

                Console.WriteLine(Progress);
                Task.Delay(100).Wait();
            }
        });
        
        BarTimer.Start();
        /*for (int i = 0; i < 2; i++)
        {
            using Stream stream = File.Open($"/ProjectGymSim/Assets/Frame{i}.png", FileMode.Open);
            Image img = new Image()
            {
                Source = new Bitmap(stream),
                IsVisible = false
            };
            GameFrame.Add(img);
        }*/

    }
    
    public void SpaceButton_OnKeyDown(object? sender, KeyEventArgs e)
    {
        Progress += 3;

    }
}