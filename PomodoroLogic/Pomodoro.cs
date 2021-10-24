using System;
using System.Timers;

namespace PomodoroLogic
{
/*
 * 1. bestäm vad som ska göras
 * 2. välj timer mellan 20 och 30 min
 * 3. arbeta
 * 4. 5-10 min break efter tiden är ute.
 * 5. repetera 2-4 4 ggr.
 * 6. efter 4e gången ta ett 30 min break.
 * 7. börja om igen om du inte är klar
 */
    public class Pomodoro
    {
        public string TaskToBeDone { get; set; }
        public int TimeInterval { get; set; }
        public int Ticks { get; set; }

        public Pomodoro()
        {
            TimeInterval = 25;
            Ticks = 0;
        }

        public void ResetTicks()
        {
            Ticks = 0;
        }

        public bool CheckTicksAre4()
        {
            return Ticks < 4;
        }




    }
}
