using System;
using System.Numerics;

namespace MohawkGame2D;

public class Player
{
    public float X { get; private set; }
    public float Y { get; private set; }
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
            X -= speed;
        }
        if (Input.IsKeyboardKeyDown(KeyboardInput.D))
        {
            X += speed;
        }

        // Prevent player from going past borders
        if (X - 20 < 20) X = 20 + 20;
        if (X + 20 > 380) X = 380 - 20;
    }

    public void ResetPosition()
    {
        X = 200;
        Y = 350;
    }

    public void Render()
    {
        Draw.FillColor = Color.Gray;
        Draw.LineColor = Color.Black;
        Draw.Circle(X, Y, 20);
    }
}
