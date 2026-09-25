using System.Numerics;

namespace Physics;

public class PhysicsWorld
{
    private readonly List<Body> _bodies = new();

    public Vector2 Gravity { get; set; } = Vector2.Zero;
    public float TimeStep { get; set; } = 1f / 60f;
    public float Damping { get; set; } = 0.999f;

    public void AddBody(Body body)
    {
        _bodies.Add(body);
    }

    public void Step()
    {
        var accelerations = new Vector2[_bodies.Count];

        for (int i = 0; i < _bodies.Count; i++)
        {
            Vector2 acceleration = Gravity;
            Body body = _bodies[i];

            foreach (var other in _bodies)
            {
                if (ReferenceEquals(body, other))
                    continue;

                acceleration += GravitySolver.CalculateAcceleration(other, body, 2000d);
            }

            accelerations[i] = acceleration;
        }

        for (int i = 0; i < _bodies.Count; i++)
        {
            Body body = _bodies[i];
            Vector2 currentPosition = body.Position;
            Vector2 acceleration = accelerations[i];

            body.Velocity = body.Velocity * Damping + acceleration * TimeStep;
            body.PreviousPosition = currentPosition;
            body.Position = currentPosition + body.Velocity * TimeStep;
        }
    }

    public IReadOnlyList<Body> Bodies => _bodies;
}