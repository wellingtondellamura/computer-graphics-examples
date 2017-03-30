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
     *  ROTAÇÃo   
     *  A rotação é feita através da função glRotatef(Ângulo, x, y, z), que pode receber 
     *  quatro números float ou double (glRotated) como parâmetro. Neste caso, a matriz 
     *  atual é multiplicada por uma matriz de rotação de "Ângulo" graus ao redor do 
     *  eixo definido pelo vetor "x,y,z" no sentido anti-horário. 
     *  Veja mais em: https://www.opengl.org/sdk/docs/man2/xhtml/glRotate.xml
     */

    public class RotateTest : IModel
    {
        private float theta = 0f;
        public void RenderFrame(object sender, FrameEventArgs e)
        {            
            GL.ClearColor(Color.Blue);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.PushMatrix();

            GL.Rotate(theta, 1.0f, 1.0f, 1.0f);

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

            theta = theta < 360f ? theta + 1f : 0f;

        }
    }
}
