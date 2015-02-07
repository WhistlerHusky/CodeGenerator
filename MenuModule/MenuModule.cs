using MenuModule.View;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace MenuModule
{
    public class MenuModule : IModule
    {
        public IUnityContainer Container;
        public IRegionManager RegionManager;
        private readonly ILoggerFacade _logger;

        public MenuModule(IUnityContainer container, ILoggerFacade logger, IRegionManager regionManager)
        {
            Container = container;
            _logger = logger;
            RegionManager = regionManager;
        }

        public void Initialize()
        {
            this._logger.Log("MenuModule Initialize()", Category.Info, Priority.Medium);

            var menuModule = Container.Resolve<MenuView>();
            RegionManager.Regions["MenuModule"].Add(menuModule);
        }
    }
}
