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

        border.Render();
        player.Update();
        triangle.Update();
        player.Render();
        triangle.Render();

 
        if (IsColliding(player, triangle))
        {
            ResetGame();
        }
    }

    private bool IsColliding(Player p, Triangle t)
    {
        float playerRadius = 20;
        float triangleSize = 10; 

        return (p.X + playerRadius > t.X - triangleSize &&
                p.X - playerRadius < t.X + triangleSize &&
                p.Y + playerRadius > t.Y &&
                p.Y - playerRadius < t.Y + 20);
    }

    private void ResetGame()
    {
        player.ResetPosition();
        triangle.ResetPosition();
    }
}
