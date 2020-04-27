using System;

namespace DotNetDemoSolution.Delegate
{
    class Event
    {
        EventHandler[] events = new EventHandler[3];

        public event EventHandler SomeEvent
        {
            add
            {
                int i;
                for (i = 0; i < 3; i++)
                    if (events[i] == null)
                    {
                        events[i] = value;
                        break;
                    }
                if (i == 3) Console.WriteLine("Event list is full.");
            }

            remove
            {
                int i;
                for (i = 0; i < 3; i++)
                    if (events[i] == value)
                    {
                        events[i] = null;
                        break;
                    }
                if (i == 3) Console.WriteLine("Event handler is not found.");
            }

        }

        public void OnSomeEvent()
        {
            for (int i = 0; i < 3; i++)
                if (events[i] != null) events[i](this, null);
        }
    }
}
