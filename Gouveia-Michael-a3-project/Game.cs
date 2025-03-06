using System;
using System.Numerics;

namespace MohawkGame2D;

public class Game
{
    private Player player;

    public void Setup()
    {
        Window.SetTitle("2D Game");
        Window.SetSize(800, 600);
        player = new Player(100, 550); // Initialize Player
    }

    public void Update()
    {
        Window.ClearBackground(Color.Cyan);

        player.Update();  // Update Player Movement
        player.Render();  // Draw Player

        // Draw a smaller red triangle facing downward, positioned higher
        Draw.FillColor = Color.Red;
        Draw.LineColor = Color.Black;
        Draw.Triangle(new Vector2(90, 85), new Vector2(110, 85), new Vector2(100, 105));
    }
}
