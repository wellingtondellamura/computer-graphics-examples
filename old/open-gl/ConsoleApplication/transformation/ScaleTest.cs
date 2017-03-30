using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace ConsoleApplication
{
    /*
     *  ESCALA   
     *  A escala é feita através da função glScalef(Ex, Ey, Ez), que pode receber três 
     *  números float ou double (glScaled) como parâmetro. Neste caso, a matriz atual 
     *  é multiplicada por uma matriz de escala baseada nos valores dados. 
     *  Veja mais em: https://www.opengl.org/sdk/docs/man2/xhtml/glScale.xml
     */

    public class ScaleTest : IModel
    {
        private float x = 0.0f;
        private float y = 0.0f;
        private float f = 0.1f;

        public void RenderFrame(object sender, FrameEventArgs e)
        {            
            GL.ClearColor(Color.Blue);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.PushMatrix();
            
            GL.Scale(x, y, 1f);

            GL.Begin(BeginMode.Quads);
                GL.Color3(Color.Red);
                GL.Vertex2(-0.5f, -0.5f);
                GL.Vertex2(-0.5f, 0.5f);
                GL.Color3(Color.Orange);
                GL.Vertex2(0.5f, 0.5f);
                GL.Vertex2(0.5f, -0.5f);
            GL.End();
            GL.PopMatrix();
            ((GameWindow)sender).SwapBuffers();

            x = x + f;
            y = y + f;

            if (x >= 1.0f)
            {
                f = f * -1f;
            }
            if (x <= 0f)
            {
                f = f * -1f;
            }
        }
    }
}
