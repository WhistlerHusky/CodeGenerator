
using System.Windows;
using Microsoft.Practices.Prism.Commands;

namespace TextEditorModule
{
    public class TextWindowViewModel
    {
        public DelegateCommand CreateNewCsharpTemplateCommand { get; set; }

        public TextWindowViewModel()
        {
            CreateNewCsharpTemplateCommand = new DelegateCommand(CreateNewCsharpTemplate);
        }

        private void CreateNewCsharpTemplate()
        {
            MessageBox.Show("CreateNewCsharpTemplateCommand");
        }
    }
}
