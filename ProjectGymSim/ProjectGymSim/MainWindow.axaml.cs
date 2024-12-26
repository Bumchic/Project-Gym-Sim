using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ProjectGymSim;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        EasyButton.Click += EasyButton_Click;
        NormalButton.Click += NormalButton_Click;
        HardButton.Click += HardButton_Click;
    }
    private void EasyButton_Click(object? sender, RoutedEventArgs e)
    {
    }

    // Xử lý sự kiện cho nút Normal
    private void NormalButton_Click(object? sender, RoutedEventArgs e)
    {
    }

    // Xử lý sự kiện cho nút Hard
    private void HardButton_Click(object? sender, RoutedEventArgs e)
    {
    }
}
