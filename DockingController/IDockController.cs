using Xceed.Wpf.AvalonDock;

namespace DockingController
{
    public interface IDockController
    {
        DockingManager DockingManager { get; set; }
    }
}
