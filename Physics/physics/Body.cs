using System.Numerics;

namespace Physics;

public class Body
{
    public double Mass { get; set; }
    public Vector2 Position { get; set; }
    public Vector2 PreviousPosition { get; set; }
    public Vector2 Velocity { get; set; }
    public double Radius { get; set; }

    public Body(double mass, Vector2 position, Vector2 velocity, double radius)
    {
        Mass = mass;
        Position = position;
        PreviousPosition = position;
        Velocity = velocity;
        Radius = radius;
    }

    public static bool IsColliding(Body a, Body b)
    {
        double distance = Vector2.Distance(a.Position, b.Position);
        return distance <= a.Radius + b.Radius;
    }
}