using System;
using System.Numerics;

namespace MohawkGame2D;

public class Game
{
    private Player player;
    private float triangleX;
    private float triangleY = 0;
    private float triangleSpeed = 4; // Adjusted for smaller screen
    private int currentIndex = 0;

    // Adjusted X coordinates for a 400x400 screen
    private readonly float[] spawnPositions = { 50, 100, 150, 200, 250, 300, 350, 75, 175, 275 };

    public void Setup()
    {
        Window.SetTitle("2D Game");
        Window.SetSize(400, 400);
        player = new Player(200, 350);
        triangleX = spawnPositions[currentIndex];
    }

    public void Update()
    {
        Window.ClearBackground(Color.Cyan);

        player.Update();
        player.Render();

        // Move the triangle down
        triangleY += triangleSpeed;

        // If the triangle moves off the bottom of the screen, reset it to the top with the next X position
        if (triangleY > 400)
        {
            triangleY = 0;
            currentIndex++;
            if (currentIndex >= spawnPositions.Length)
            {
                currentIndex = 0;
            }
            triangleX = spawnPositions[currentIndex];
        }

        // Draw the falling triangle
        Draw.FillColor = Color.Red;
        Draw.LineColor = Color.Black;
        Draw.Triangle(
            new Vector2(triangleX - 10, triangleY),
            new Vector2(triangleX + 10, triangleY),
            new Vector2(triangleX, triangleY + 20)
        );
    }
}
