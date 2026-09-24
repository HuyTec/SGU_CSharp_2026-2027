using System.Numerics;

namespace Physics;

public static class GravitySolver
{
    public static Vector2 CalculateAcceleration(
        Body source,
        Body target,
        double gravitationalConstant)
    {
        Vector2 delta = source.Position - target.Position;
        double distanceSquared = (double)delta.X * delta.X + (double)delta.Y * delta.Y;

        if (distanceSquared <= 0.0001)
            return Vector2.Zero;

        double distance = Math.Sqrt(distanceSquared);
        Vector2 direction = delta / (float)distance;

        double acceleration = gravitationalConstant * source.Mass / distanceSquared;
        return direction * (float)acceleration;
    }
}