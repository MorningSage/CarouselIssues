using Avalonia.Controls;

namespace CarouselIssues;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        LeftButton.Click += (s, e) => Carousel.Previous();
        RightButton.Click += (s, e) => Carousel.Next();
    }
}