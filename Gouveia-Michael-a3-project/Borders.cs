using System;
using System.Numerics;

namespace MohawkGame2D;

public class Border
{
    private float leftX = 0;   // Fix: Start at 0 instead of 20
    private float rightX = 380;
    private float width = 20;
    private float height = 400;

    public void CheckCollision(Player player)
    {
        if (player.X - 20 < leftX + width) player.X = leftX + width;
        if (player.X + 20 > rightX) player.X = rightX - 20;
    }

    public void Render()
    {
        Draw.FillColor = Color.Red;
        Draw.Rectangle(leftX, 0, width, height);  // Left border (now starts at 0)
        Draw.Rectangle(rightX, 0, width, height); // Right border
    }
}
