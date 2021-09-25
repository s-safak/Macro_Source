using System;
using System.Windows.Forms;

namespace GlobalMacroRecorder
{

    /// <summary>
    /// All possible events that macro can record
    /// </summary>
    [Serializable]
    public enum MacroEventType
    {
        MouseMove,
        MouseDown,
        MouseUp,
        MouseWheel,
        KeyDown,
        KeyUp
    }

    /// <summary>
    /// Series of events that can be recorded any played back
    /// </summary>
    [Serializable]
    public class MacroEvent
    {
        
        public MacroEventType MacroEventType;
        public object EventArgs;
        public int TimeSinceLastEvent;
        /*public List<MacroEvent> events = new List<MacroEvent>();
        public List<MacroEvent> Events
        {
            get { return events; }
            set { events = value; }
        }*/

        public MacroEvent(MacroEventType macroEventType, EventArgs eventArgs, int timeSinceLastEvent)
        {
            MacroEventType = macroEventType;
            switch (macroEventType)
            {
                case MacroEventType.MouseMove:
                case MacroEventType.MouseDown:
                case MacroEventType.MouseUp:
                case MacroEventType.MouseWheel:
                    EventArgs = new MyMouseEventArgs((MouseEventArgs)eventArgs);
                    break;
                case MacroEventType.KeyDown:
                case MacroEventType.KeyUp:
                    EventArgs = new MyKeyEventArgs((KeyEventArgs)eventArgs);
                    break;
                default:
                    break;
            }
            
            TimeSinceLastEvent = timeSinceLastEvent;
        }
    }
}
