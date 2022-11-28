using Microsoft.Maui.Layouts;
using System.Diagnostics;

namespace MauiApp39;

public partial class MainPage : ContentPage
{
    //private readonly Stopwatch _stopwatch = Stopwatch.StartNew();

    public MainPage() => InitializeComponent();

    //protected override void OnHandlerChanged()
    //{
    //    base.OnHandlerChanged();
    //    label.Animate("ඞ", p =>
    //    {
    //        label.Text = $"{_stopwatch.ElapsedMilliseconds} ms since last update";
    //        _stopwatch.Restart();
    //    }, 1, length: 10000, repeat: () => true);
    //}
}

public class MyLayout : Layout
{
    protected override ILayoutManager CreateLayoutManager() => new MyLayoutManager(this);
}

public class MyLayoutManager : LayoutManager
{
    public MyLayoutManager(Microsoft.Maui.ILayout layout) : base(layout)
    {
    }

    public override Size ArrangeChildren(Rect bounds)
    {
        //Thread.Sleep(100); // Simulates layout in larger apps
        foreach (IView view in Layout)
        {
            view.Arrange(bounds);
        }

        return new();
    }

    public override Size Measure(double widthConstraint, double heightConstraint) => new(200, 200);
}