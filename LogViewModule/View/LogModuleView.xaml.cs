using System.Windows.Controls;
using LogModule.ViewModel;

namespace LogModule
{
    /// <summary>
    /// Interaction logic for LogViewModule.xaml
    /// </summary>
    public partial class LogModuleView : UserControl
    {
        public LogModuleView()
        {
            InitializeComponent();
            DataContext = new LogDataViewModel();
        }
    }
}
