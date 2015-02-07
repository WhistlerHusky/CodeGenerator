using System.Windows;

namespace CodeGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Shell : Window
    {
        public Shell()
        {
            InitializeComponent();
        }
        public Microsoft.Practices.Unity.IUnityContainer Container { get; set; }

    }
}
