using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public interface IModel
    {
        void RenderFrame(object sender, OpenTK.FrameEventArgs e);
    }
}
