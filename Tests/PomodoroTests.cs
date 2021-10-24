using System;
using System.Runtime.CompilerServices;
using PomodoroLogic;
using Xunit;

namespace Tests
{
    public class PomodoroTests
    {
        private Pomodoro _pomodoro;
        private MockTime _mockTime;

        public PomodoroTests()
        {
            _mockTime = new MockTime();
            _pomodoro = new Pomodoro();
        }

        [Fact]
        public void Test_TaskSet()
        {
            _pomodoro.TaskToBeDone = "Powerwash the house";
            string taskToBeDone = _pomodoro.TaskToBeDone;

            Assert.Equal("Powerwash the house", taskToBeDone);
        }

        [Fact]
        public void Test_TimerSet()
        {
            int timer = _pomodoro.TimeInterval;

            Assert.Equal(25,timer);
        }
    }
}
