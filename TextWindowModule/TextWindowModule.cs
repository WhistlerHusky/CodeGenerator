
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace TextEditorModule
{
    public class TextEditorModule : IModule
    {
        public IUnityContainer Container;
        public IRegionManager RegionManager;
        private readonly ILoggerFacade _logger;

        public TextEditorModule(IUnityContainer container, ILoggerFacade logger, IRegionManager regionManager)
        {
            Container = container;
            _logger = logger;
            RegionManager = regionManager;
        }

        public void Initialize()
        {
            this._logger.Log("TextEditorModule Initialize()", Category.Info, Priority.Medium);
    
            var module = Container.Resolve<TextEditorModuleView>();
            //RegionManager.Regions["TextEditorModule"].Add(module);
        }
    }
}
