
namespace LogModule
{
    public class LogData
    {
        private string _date;
        private string _description;

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
