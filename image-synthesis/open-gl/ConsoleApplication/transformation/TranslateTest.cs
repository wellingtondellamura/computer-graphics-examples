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
     *  TRANSLAÇÃO   
     *  A translação é feita através da função glTranslatef(Tx, Ty, Tz), que pode 
     *  receber três números float ou double (glTranslated) como parâmetro. Neste 
     *  caso, a matriz atual é multiplicada por uma matriz de translação baseada 
     *  nos valores dados. 
     *  Veja mais em: https://www.opengl.org/sdk/docs/man2/xhtml/glTranslate.xml
     */

    public class TranslateTest : IModel
    {
        private float x = -1.0f;
        private float y = -1.0f;

        public void RenderFrame(object sender, FrameEventArgs e)
        {            
            GL.ClearColor(Color.Blue);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.PushMatrix();

            GL.Translate(x, y, 1f);

            GL.Begin(BeginMode.Quads);
                GL.Color3(Color.Green);
                GL.Vertex2(-0.5f, -0.5f);
                GL.Vertex2(-0.5f, 0.5f);
                GL.Color3(Color.Purple);
                GL.Vertex2(0.5f, 0.5f);
                GL.Vertex2(0.5f, -0.5f);
            GL.End();
            GL.PopMatrix();
            ((GameWindow)sender).SwapBuffers();

            x = x + 0.01f;
            y = y + 0.01f;
            if (x > 2.0f)
                x = -1.0f;
            if (y > 2.0f)
                y = -1.0f;
        }
    }
}
