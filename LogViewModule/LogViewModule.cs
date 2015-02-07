using System;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace LogModule
{
    public class LogModule : IModule
    {
        public IUnityContainer Container;
        public IRegionManager RegionManager;
        private readonly ILoggerFacade _logger;

        public LogModule(IUnityContainer container, ILoggerFacade logger, IRegionManager regionManager)
        {
            Container = container;
            _logger = logger;
            RegionManager = regionManager;
        }

        public void Initialize()
        {
            this._logger.Log("LogModule Initialize()", Category.Info, Priority.Medium);

            var menuModule = Container.Resolve<LogModuleView>();
            RegionManager.Regions["LogModule"].Add(menuModule);
        }
    }
}
