using Silk.NET.Maths;
using Silk.NET.Windowing;
using SnubDodecahedron.Core;

namespace SnubDodecahedron;

class Program
{
    static void Main()
    {
        var options = WindowOptions.Default;
        options.Size = new Vector2D<int>( 800, 600 );

        var window = Window.Create( options );
        new WindowApp( window );

        window.Run();
    }
}