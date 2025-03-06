using System;
using System.Numerics;

namespace MohawkGame2D;

public class Player
{
    public float X { get; private set; }
    public float Y { get; private set; }
    private float speed = 5;

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
    }

    public void Render()
    {
        Draw.FillColor = Color.Gray;
        Draw.LineColor = Color.Black;
        Draw.Circle(X, Y, 20);
    }
}

