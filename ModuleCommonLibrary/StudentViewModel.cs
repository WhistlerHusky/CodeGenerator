using System.Collections.ObjectModel;
using System.Windows.Controls;
using Microsoft.Practices.Prism.Commands;

namespace ModuleCommonLibrary
{
    public class StudentViewModel
    {

        public DelegateCommand<object> ButtonClicked { get { return new DelegateCommand<object>(UpdateAlbumArtistsExecute); } }
        //public TestConverter TestConverter2 { get; set; }
        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }

        private ObservableCollection<Student> _students;

        public StudentViewModel()
        {
            Students = new ObservableCollection<Student>
                {
                    new Student{ StudentName = "Jun", StudentNumber = "20021635"},
                    new Student{ StudentName = "Han", StudentNumber = "20021636"}
                };
        }

        void UpdateAlbumArtistsExecute(object parameter)
        {
            object[] obj = parameter as object[];
            var textBox1 = obj[0] as TextBox;
            var textBox2 = obj[1] as TextBox;
            Student student = new Student
            {
                StudentName = textBox1.Text,
                StudentNumber = textBox2.Text
            };

            if (student != null)
            {
                _students.Add(student);
            }
        }
    }

}
