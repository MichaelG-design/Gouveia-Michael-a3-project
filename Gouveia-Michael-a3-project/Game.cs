using System;
using System.Numerics;

namespace MohawkGame2D;

public class Game
{
    private float circleX = 100;
    private float circleY = 550;

    public void Setup()
    {
        Window.SetTitle("2D Game");
        Window.SetSize(800, 600);
    }

    public void Update()
    {
        Window.ClearBackground(Color.OffWhite);

        if (Input.IsKeyboardKeyDown(KeyboardInput.A))
        {
            circleX -= 5; // Move left
        }
        if (Input.IsKeyboardKeyDown(KeyboardInput.D))
        {
            circleX += 5; // Move right
        }

        Draw.FillColor = Color.Blue;
        Draw.LineColor = Color.Black;
        Draw.Circle(circleX, circleY, 20);
    }
}
