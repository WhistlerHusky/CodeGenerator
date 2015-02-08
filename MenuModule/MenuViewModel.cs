using System.Windows;
using Microsoft.Practices.Prism.Commands;

namespace MenuModule.ViewModel
{
    public class MenuViewModel
    {
        public DelegateCommand CreateNewCSharpTemplateCommand { get; set; }


        public MenuViewModel()
        {
            CreateNewCSharpTemplateCommand = new DelegateCommand(CreateNewCShaprTemplate);
        }

        private void CreateNewCShaprTemplate()
        {
            MessageBox.Show("Test");
        }
    }
}
