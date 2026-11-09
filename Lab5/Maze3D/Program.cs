using Silk.NET.Maths;
using Silk.NET.Windowing;
using Maze3D.Core;

namespace Maze3D;
class Program
{
    static Game game;

    static void Main()
    {
        var options = WindowOptions.Default;
        options.Size = new Vector2D<int>(Constants.WINDOW_WIDTH, Constants.WINDOW_HEIGHT);
        options.Title = Constants.WINDOW_TITLE;

        var window = Window.Create(options);
        game = new Game(window);

        window.Load += game.OnLoad;
        window.Update += game.OnUpdate;
        window.Render += game.OnRender;

        window.Run();
    }
}