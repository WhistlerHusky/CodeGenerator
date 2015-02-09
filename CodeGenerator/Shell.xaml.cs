using System.Windows;
using Xceed.Wpf.AvalonDock;

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

        private void Onload(object sender, RoutedEventArgs e)
        {
  
        }
    }
}
