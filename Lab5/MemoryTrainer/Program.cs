using MemoryTrainer.Core;
using MemoryTrainer.Input;
using MemoryTrainer.Rendering;
using Silk.NET.Maths;
using Silk.NET.Windowing;

class Program
{
    static void Main()
    {
        var opts = WindowOptions.Default with
        {
            Size = new Vector2D<int>( 1500, 1000 ),
            Title = "Memory Trainer 3D",
            WindowState = WindowState.Normal
        };

        using var window = Window.Create( opts );

        var game = new Game( 4, 4, 1.5f );
        var renderer = new Renderer( window, game );
        var inputHandler = new InputHandler( window, renderer.Camera, game );

        window.Load += () =>
        {
            renderer.Load();
            game.Initialize();
        };
        window.Update += game.Update;
        window.Render += renderer.Render;

        window.Run();
    }
}
