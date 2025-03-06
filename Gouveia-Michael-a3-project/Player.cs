using System;
using System.Numerics;

namespace MohawkGame2D;

public class Player
{
    public float X { get; set; } // Changed from private to public
    public float Y { get; set; }
    public float speed = 5;

    public Player(float startX, float startY)
    {
        X = startX;
        Y = startY;
    }

    public void Update()
    {
        if (Input.IsKeyboardKeyDown(KeyboardInput.A))
        {
            X -= speed; // Move left
        }
        if (Input.IsKeyboardKeyDown(KeyboardInput.D))
        {
            X += speed; // Move right
        }

        // Keep player inside the screen borders
        if (X - 20 < 20) X = 20 + 20;   // Left wall
        if (X + 20 > 380) X = 380 - 20; // Right wall
    }

    public void Render()
    {
        Draw.FillColor = Color.Gray;
        Draw.LineColor = Color.Black;
        Draw.Circle(X, Y, 20);
    }

}
