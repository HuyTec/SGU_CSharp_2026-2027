using System.Numerics;
using System.Windows;
using System.Windows.Threading;

namespace Physics;

public partial class MainWindow : Window
{
    private readonly PhysicsWorld _world = new();
    private readonly DispatcherTimer _timer = new();

    public MainWindow()
    {
        InitializeComponent();
        Loaded += OnLoaded;
        Closing += (_, _) => _timer.Stop();
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        var body1 = new Body(20, new Vector2(300, 120), new Vector2(0, 0), 24);
        var body2 = new Body(30, new Vector2(550, 220), new Vector2(0, 0), 28);

        _world.AddBody(body1);
        _world.AddBody(body2);
        _world.Gravity = Vector2.Zero;

        _timer.Interval = TimeSpan.FromMilliseconds(16.6);
        _timer.Tick += (_, _) =>
        {
            _world.Step();
            SimulationCanvas.Render(_world.Bodies);
        };

        _timer.Start();
    }
}
