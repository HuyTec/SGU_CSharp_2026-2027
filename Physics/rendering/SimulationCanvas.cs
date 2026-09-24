using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Physics;

public class SimulationCanvas : Canvas
{
    public void Render(IReadOnlyList<Body> bodies)
    {
        Children.Clear();

        foreach (var body in bodies)
        {
            var ellipse = new Ellipse
            {
                Width = body.Radius * 2,
                Height = body.Radius * 2,
                Fill = Brushes.Orange,
                Stroke = Brushes.White,
                StrokeThickness = 1.5
            };

            SetLeft(ellipse, body.Position.X - body.Radius);
            SetTop(ellipse, body.Position.Y - body.Radius);
            Children.Add(ellipse);
        }
    }
}
