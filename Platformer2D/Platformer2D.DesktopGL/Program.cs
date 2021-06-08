using System;

namespace Platformer2D.DesktopGL
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            var game = new PlatformerGame();

            game.Run();
        }
    }
}
