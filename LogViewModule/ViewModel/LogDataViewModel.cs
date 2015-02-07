using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;

namespace LogModule.ViewModel
{
    public class LogDataViewModel
    {
        public ICollectionView LogData { get; set; }

        public LogDataViewModel()
        {
            var _logData = new List<LogData>
            {
                new LogData {
                    Date = System.DateTime.Now.ToString(),
                    Description = "System.DateTime.Now.ToString()"
                },
                new LogData {
                    Date = System.DateTime.Now.ToString(),
                    Description = "System.DateTime.Now.ToString()"
                }
            };

            LogData = CollectionViewSource.GetDefaultView(_logData);
        }
    }
}
