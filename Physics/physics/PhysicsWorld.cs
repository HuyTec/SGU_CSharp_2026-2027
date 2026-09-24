using System.Numerics;

namespace Physics;

public class PhysicsWorld
{
    private readonly List<Body> _bodies = new();

    public Vector2 Gravity { get; set; } = new(0f, 9.81f);
    public float TimeStep { get; set; } = 1f / 60f;
    public float Damping { get; set; } = 0.999f;

    public void AddBody(Body body)
    {
        _bodies.Add(body);
    }

    public void Step()
    {
        foreach (var body in _bodies)
        {
            Vector2 currentPosition = body.Position;
            Vector2 previousPosition = body.PreviousPosition;
            Vector2 velocity = (currentPosition - previousPosition) * Damping;
            body.Velocity = velocity;

            Vector2 acceleration = Gravity;

            foreach (var other in _bodies)
            {
                if (ReferenceEquals(body, other))
                    continue;

                acceleration += GravitySolver.CalculateAcceleration(other, body, 2000d);
            }

            Vector2 nextPosition = currentPosition + (currentPosition - previousPosition) + acceleration * TimeStep * TimeStep;
            body.PreviousPosition = currentPosition;
            body.Position = nextPosition;
        }
    }

    public IReadOnlyList<Body> Bodies => _bodies;
}