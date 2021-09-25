using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GlobalMacroRecorder
{
    [Serializable]
    public class MyMouseEventArgs
    {
        public MyMouseEventArgs(MouseButtons button, int clicks, int x, int y, int delta) 
        {
            Button = button;
            Clicks = clicks;
            X = x;
            Y = y;
            Delta = delta;
        }

        public MyMouseEventArgs(MouseEventArgs eventArgs)
        {
            Button = eventArgs.Button;
            Clicks = eventArgs.Clicks;
            X = eventArgs.X;
            Y = eventArgs.Y;
            Delta = eventArgs.Delta;
        }

        public MouseButtons Button { get; }
     
        public int Clicks { get; }
   
        public int X { get; }
 
        public int Y { get; }
   
        public int Delta { get; }

    }

    [Serializable]
    public class MyKeyEventArgs
    {
        public MyKeyEventArgs(Keys key)
        {
            KeyCode = key;
        }

        public MyKeyEventArgs(KeyEventArgs eventArgs)
        {
            KeyCode = eventArgs.KeyCode;
        }

        public Keys KeyCode { get; }
    }
}
