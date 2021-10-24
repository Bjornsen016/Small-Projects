using System;

namespace PomodoroLogic
{
    public class RealTime : ITime
    {
        public DateTime Now
        {
            get => DateTime.Now;
            set {}
        }
    }
}