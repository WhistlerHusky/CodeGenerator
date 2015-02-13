using System;
using Xceed.Wpf.AvalonDock;

namespace DockingController
{
    public class DockController : IDockController
    {
        private DockingManager _dockingManager = new DockingManager();
        public DockingManager DockingManager 
        { 
            get
            {
                return _dockingManager;
            } 
            set
                
            {
                _dockingManager = value; 
            }
        }
    }
}
