using System;
using System.Numerics;

namespace MohawkGame2D;

public class Game
{
    private Player player;
    private Triangle triangle;

    public void Setup()
    {
        Window.SetTitle("2D Game");
        Window.SetSize(400, 400);
        player = new Player(200, 350); // Initialize Player
        triangle = new Triangle(); // Initialize Triangle
    }

    public void Update()
    {
        Window.ClearBackground(Color.Cyan);

        player.Update();
        player.Render();

        triangle.Update();
        triangle.Render();
    }
}