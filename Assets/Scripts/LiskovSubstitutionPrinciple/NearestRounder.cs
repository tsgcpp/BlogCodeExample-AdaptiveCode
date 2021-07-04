using System;

public sealed class NearestRounder : IRounder
{
    public float Round(float value, float interval)
    {
        if (interval <= 0f)
        {
            throw new RounderException("\"interval\" is 0 or less");
        }

        return (float)Math.Round(value / interval) * interval;
    }
}