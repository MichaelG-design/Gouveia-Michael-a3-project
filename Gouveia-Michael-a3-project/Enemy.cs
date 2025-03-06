using System;
using System.Numerics;

namespace MohawkGame2D;

public class Triangle
{
    private float[] spawnX = { 50, 100, 150, 200, 250, 300, 350 }; // Fixed spawn positions
    private int currentIndex = 0;
    private float x;
    private float y = 0;
    private float speed = 8; // Increased speed

    public Triangle()
    {
        x = spawnX[currentIndex];
    }

    public void Update()
    {
        y += speed;
        if (y > 400)
        {
            y = 0;
            currentIndex = (currentIndex + 1) % spawnX.Length;
            x = spawnX[currentIndex];
        }
    }

    public void Render()
    {
        Draw.FillColor = Color.Red;
        Draw.LineColor = Color.Black;
        Draw.Triangle(
            new Vector2(x - 10, y),   // Top-left
            new Vector2(x + 10, y),   // Top-right
            new Vector2(x, y + 20)    // Bottom center
        );
    }
}
