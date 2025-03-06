using System;
using System.Numerics;

namespace MohawkGame2D;

public class Border
{
    private float wallWidth = 20;

    public void Render()
    {
        Draw.FillColor = Color.Red;
        Draw.Rectangle(0, 0, wallWidth, 400);   // Left border
        Draw.Rectangle(380, 0, wallWidth, 400); // Right border
    }
}
