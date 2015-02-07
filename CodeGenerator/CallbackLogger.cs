using System;
using System.Collections.Generic;
using Microsoft.Practices.Prism.Logging;

namespace CodeGenerator
{
    public class CallbackLogger : ILoggerFacade
    {
        private Queue<Tuple<string, Category, Priority>> _savedLogs = new Queue<Tuple<string, Category, Priority>>();
        private Action<string, Category, Priority> _callback;

        public Action<string, Category, Priority> Callback
        {
            get { return _callback; }
            set { _callback = value; }
        }

        public Queue<Tuple<string, Category, Priority>> SavedLogs
        {
            get { return _savedLogs; }
            set { _savedLogs = value; }
        }

        public void Log(string message, Category category, Priority priority)
        {
            if (this._callback != null)
            {
                this._callback(message, category, priority);
            }
            else
            {
                _savedLogs.Enqueue(new Tuple<string, Category, Priority>(message, category, priority));
            }
        }

        public void ReplaySavedLogs()
        {
            if (this.Callback != null)
            {
                while (this._savedLogs.Count > 0)
                {
                    var log = this._savedLogs.Dequeue();
                    this.Callback(log.Item1, log.Item2, log.Item3);
                }
            }
        }
    }

}
