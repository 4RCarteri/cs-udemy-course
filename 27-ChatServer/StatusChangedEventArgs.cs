using System;

namespace _27_ChatServer
{
    // EventArgs is a class in the System namespace that is the base class for classes containing event data.
    public class StatusChangedEventArgs : EventArgs
    {
        private string EventMsg;
        public string EventMessage
        {
            get { return EventMsg; }

            set { EventMsg = value; }
        }

        public StatusChangedEventArgs(string eventMsg)
        {
            EventMsg = eventMsg;

        }
    }
}
