

using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Threading;
using System.Drawing;
using OpenTK.Input;

namespace ConsoleApplication
{
    class MyApplication
    {

        [STAThread]
        public static void Main()
        {
            IModel m = new RotateTest();

            var game = new GameWindow(800,600);
            game.RenderFrame += m.RenderFrame;
            game.Resize += Game_Resize;
            game.WindowBorder = WindowBorder.Resizable;
            game.Title = "OPEN TK Test";
            game.WindowState = WindowState.Normal;
            game.Run(60.0);            
        }

        private static void Game_Resize(object sender, EventArgs e)
        {
            var game = (GameWindow)sender;
            GL.Viewport(0, 0, game.Width, game.Height);
        }        

    }
 }