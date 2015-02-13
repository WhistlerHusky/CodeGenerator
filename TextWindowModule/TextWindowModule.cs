
using System.Runtime.InteropServices.ComTypes;
using DockingController;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace TextEditorModule
{
    public class TextEditorModule : IModule
    {
        public IUnityContainer Container;
        public IRegionManager RegionManager;
        private readonly ILoggerFacade _logger;
        private IDockController _dockController;
        private IEventAggregator _eventAggregator;

        public TextEditorModule(IUnityContainer container, ILoggerFacade logger, IDockController dockController, IEventAggregator eventAggregator)
        {
            Container = container;
            _logger = logger;
            _dockController = dockController;
            _eventAggregator = eventAggregator;
        }

        public void Initialize()
        {
            this._logger.Log("TextEditorModule Initialize()", Category.Info, Priority.Medium);

            var textEditorModuleView = new TextEditorModuleEventAggregation(_eventAggregator, _dockController);
            Container.RegisterInstance(textEditorModuleView);
        }
    }
}
