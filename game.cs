using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace practicaOpenTK1
{
    class game
    {
        GameWindow window;
        public game(GameWindow window)
        {
            this.window = window;
            this.Start();
        }

        void Start()
        {
            window.Load += loaded;
            window.Resize += resize;
            window.RenderFrame += renderF;
            window.Run(1.0 / 60.0);
        }
        void resize(object ob, EventArgs e)
        {
            GL.Viewport(0, 0, window.Width, window.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0.0, 50.0, 0.0, 50.0, -1.0, 1.0);
            GL.MatrixMode(MatrixMode.Modelview);
        }

        void renderF(object o, EventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            //GL.Begin(BeginMode.Lines);
            //GL.Vertex2(10.0, 45.0);
            //GL.Vertex2(10.0, 5.0);
            
            //para la silla (usamos 3 cuadrados)
            GL.Begin(BeginMode.QuadStrip);
            GL.Vertex2(10.0, 5.0);
            GL.Vertex2(15.0, 5.0);
            GL.Vertex2(10.0, 40.0);
            GL.Vertex2(15.0, 40.0);
            GL.End();
            GL.Begin(BeginMode.QuadStrip);
            GL.Vertex2(35.0, 5.0);
            GL.Vertex2(40.0, 5.0);
            GL.Vertex2(35.0, 20.0);
            GL.Vertex2(40.0, 20.0);
            GL.Begin(BeginMode.QuadStrip);
            GL.Vertex2(15.0, 20.0);
            GL.Vertex2(15.0, 25.0);
            GL.Vertex2(40.0, 20.0);
            GL.Vertex2(40.0, 25.0);
            
            GL.End();
            window.SwapBuffers();
        }

        void loaded(object o, EventArgs e)
        {
            GL.ClearColor(0.0f,0.0f,0.0f,0.0f);
        }
    }
}
