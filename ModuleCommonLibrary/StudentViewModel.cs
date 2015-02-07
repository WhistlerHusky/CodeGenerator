using System.ComponentModel;

namespace ModuleCommonLibrary
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        private Student _student;

        public event PropertyChangedEventHandler PropertyChanged;

        public StudentViewModel()
        {
            _student = new Student { StudentName = "Unknown", StudentNumber = "Unknow" };
        }
        void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string StudentNumber
        {
            get
            {
                return _student.StudentNumber;
            }
            set
            {
                if (_student.StudentNumber == value)
                    return;

                _student.StudentNumber = value;
                RaisePropertyChanged("StudentNumber");
            }
        }

        public string StudentName
        {
            get
            {
                return _student.StudentName;
            }
            set
            {
                if (_student.StudentName == value)
                    return;

                _student.StudentName = value;
                RaisePropertyChanged("StudentName");
            }
        }
    }
}