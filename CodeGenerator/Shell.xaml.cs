using System.Windows;
using DockingController;
using Xceed.Wpf.AvalonDock;

namespace CodeGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Shell : Window
    {
        //public Microsoft.Practices.Unity.IUnityContainer Container { get; set; }
        public Shell()
        {
            InitializeComponent();
        }

        public Shell(IDockController dock)
            : this()
        {
            dock.DockingManager = dockingManager;
        }
    }
}
