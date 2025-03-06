using System;
using System.Numerics;

namespace MohawkGame2D;

public class Triangle
{
    private float[] spawnX = { 50, 100, 150, 200, 250, 300, 350 };
    private int currentIndex = 0;
    public float X { get; private set; }
    public float Y { get; private set; }
    private float speed = 8;

    public Triangle()
    {
        X = spawnX[currentIndex];
        Y = 0;
    }

    public void Update()
    {
        Y += speed;
        if (Y > 400)
        {
            Y = 0;
            currentIndex = (currentIndex + 1) % spawnX.Length;
            X = spawnX[currentIndex];
        }
    }

    public void ResetPosition()
    {
        Y = 0;
        currentIndex = 0;
        X = spawnX[currentIndex];
    }

    public void Render()
    {
        Draw.FillColor = Color.Red;
        Draw.LineColor = Color.Black;
        Draw.Triangle(
            new Vector2(X - 10, Y),
            new Vector2(X + 10, Y),
            new Vector2(X, Y + 20)
        );
    }
}
