using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaOpenTK1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindow window = new GameWindow(500, 500);
            game gm = new game(window);
        }
    }
}
