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

    public class CubeTest : IModel
    {
        Matrix4 matrixProjection, matrixModelview;
        float cameraRotation = 0f;

        public void RenderFrame(object sender, FrameEventArgs e)
        {

            cameraRotation = (cameraRotation < 360f) ? (cameraRotation + 1f * (float)e.Time) : 0f;
            Matrix4.CreateRotationY(cameraRotation, out matrixModelview);
            matrixModelview *= Matrix4.LookAt(0f, 0f, -5f, 0f, 0f, 0f, 0f, 1f, 0f);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref matrixModelview);

            GL.ClearColor(Color.Blue);
           
            GL.LoadIdentity();

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.PushMatrix();

            GL.Color3(Color.Blue);

            // Desenha um cubo

            GL.Begin(BeginMode.Quads);          // Face posterior
            GL.Normal3(0.0, 0.0, 1.0);  // Normal da face
            GL.Vertex3(40.0, 40.0, 40.0);
            GL.Vertex3(-40.0, 40.0, 40.0);
            GL.Vertex3(-40.0, -40.0, 40.0);
            GL.Vertex3(40.0, -40.0, 40.0);
            GL.End();


            GL.Begin(BeginMode.Quads);          // Face frontal
            GL.Normal3(0.0, 0.0, -1.0);     // Normal da face
            GL.Vertex3(40.0, 40.0, -40.0);
            GL.Vertex3(40.0, -40.0, -40.0);
            GL.Vertex3(-40.0, -40.0, -40.0);
            GL.Vertex3(-40.0, 40.0, -40.0);
            GL.End();

            GL.Begin(BeginMode.Quads);          // Face lateral esquerda
            GL.Normal3(-1.0, 0.0, 0.0);     // Normal da face
            GL.Vertex3(-40.0, 40.0, 40.0);
            GL.Vertex3(-40.0, 40.0, -40.0);
            GL.Vertex3(-40.0, -40.0, -40.0);
            GL.Vertex3(-40.0, -40.0, 40.0);
            GL.End();

            GL.Begin(BeginMode.Quads); // Face lateral direita
            GL.Normal3(1.0, 0.0, 0.0);  // Normal da face
            GL.Vertex3(40.0, 40.0, 40.0);
            GL.Vertex3(40.0, -40.0, 40.0);
            GL.Vertex3(40.0, -40.0, -40.0);
            GL.Vertex3(40.0, 40.0, -40.0);
            GL.End();

            GL.Begin(BeginMode.Quads); // Face superior
            GL.Normal3(0.0, 1.0, 0.0);      // Normal da face
            GL.Vertex3(-40.0, 40.0, -40.0);
            GL.Vertex3(-40.0, 40.0, 40.0);
            GL.Vertex3(40.0, 40.0, 40.0);
            GL.Vertex3(40.0, 40.0, -40.0);
            GL.End();

            GL.Begin(BeginMode.Quads); // Face inferior
            GL.Normal3(0.0, -1.0, 0.0);     // Normal da face
            GL.Vertex3(-40.0, -40.0, -40.0);
            GL.Vertex3(40.0, -40.0, -40.0);
            GL.Vertex3(40.0, -40.0, 40.0);
            GL.Vertex3(-40.0, -40.0, 40.0);
            GL.End();

            GL.PopMatrix();
            ((GameWindow)sender).SwapBuffers();

        }
    }
}
