using System.Windows.Controls;
using System.Windows.Documents;

namespace TextEditorModule
{
    /// <summary>
    /// Interaction logic for TextWindowModuleView.xaml
    /// </summary>
    public partial class TextEditorModuleView : UserControl
    {
        public TextEditorModuleView()
        {
            InitializeComponent();
            DataContext = new TextWindowViewModel();
        }
    }
}
