using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private bool _isRunning;
        private TimeSpan _duration;

        public void Start() 
        {
            if (_isRunning) throw new InvalidOperationException("Stopwatch is already running.");
            _startTime = DateTime.Now;
               _isRunning = true;
        }

        public void Stop() 
        { 
            if(!_isRunning) throw new InvalidOperationException("Stopwatch is not running.");
            _duration += DateTime.Now - _startTime;
              _isRunning = false;
        }

        public TimeSpan ElapsedTime
        {
            get 
            {
                var elapsedTime = _duration;
                if (_isRunning)
                   elapsedTime += DateTime.Now - _startTime;
                return elapsedTime;
            }
        }

        public void Reset()
        {
            _isRunning = false;
            _duration = TimeSpan.Zero;
        }
    }
}
