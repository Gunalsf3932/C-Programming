using System;

namespace Event
{
    public delegate void EventManager();
    public class Events
    {
        private string _eventName;
        public static event EventManager eventlink=null;   
        static int i;
        public Events(string eventName)
        {
            _eventName=eventName;
        }
        public static void HandleEvent()
        {
            i=0;
            System.Console.WriteLine("User Registration");
            System.Console.WriteLine("Starting the following events ");
            eventlink();
        }
        public void ShowEvent()
        {
            ++i;
            System.Console.WriteLine("Event No" + i + " is : "+_eventName+"Started");
        }

    }
}
