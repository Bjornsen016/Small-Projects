using System;
using PomodoroLogic;

namespace Tests
{
    public class MockTime : ITime
    {
        private DateTime _fakeNow = DateTime.Now;

        public DateTime Now
        {
            get => _fakeNow;
            set => _fakeNow = value;
        }
    }
}