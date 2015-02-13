using System.Linq;
using System.Windows.Controls;
using DockingController;
using Xceed.Wpf.AvalonDock.Layout;

namespace MenuModule.MenuEvents
{
    public class CreateNewFileMenuEvent : IMenuEvent
    {
        private readonly IDockController _dockController;

        public CreateNewFileMenuEvent(IDockController dockController)
        {
            this._dockController = dockController;
        }

        public void RunMenuEvent()
        {
            var firstDocumentPane = _dockController.DockingManager.Layout.Descendents().OfType<LayoutDocumentPane>().FirstOrDefault();
            
            if (firstDocumentPane != null)
            {
                var doc = new LayoutDocument {Title = "Untitle*"};
                doc.Content = new RichTextBox {VerticalScrollBarVisibility = ScrollBarVisibility.Auto};
                firstDocumentPane.Children.Add(doc);
            }
        }
    }
}
