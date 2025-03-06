using System;
using System.Numerics;

namespace MohawkGame2D;

public class Game
{
    private Player player;
    private Triangle triangle;
    private Border border;

    public void Setup()
    {
        Window.SetTitle("2D Game");
        Window.SetSize(400, 400);
        player = new Player(200, 350);
        triangle = new Triangle();
        border = new Border();
    }

    public void Update()
    {
        Window.ClearBackground(Color.Cyan);

        player.Update();
        border.CheckCollision(player); // Prevents player from passing the borders

        border.Render(); // Draw borders
        player.Render();
        triangle.Update();
        triangle.Render();
    }
}
