using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class Stopwatch
    {
        private Boolean _hasStarted;
        public DateTime _startTime;
        public TimeSpan Duration { get; private set; }
        
        public void Start()
        {
            if (_hasStarted)
            {
                throw new InvalidOperationException();
            }

            _hasStarted = true;
            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            _hasStarted = false;
            Duration = DateTime.Now - _startTime;
        }
    }
}
