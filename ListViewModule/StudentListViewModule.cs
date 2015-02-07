using ListViewModule.View;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace ListViewModule
{
    public class StudentListViewModule : IModule
    {
        public IUnityContainer Container { get; private set; }
        public IRegionManager RegionManager { get; private set; }private readonly ILoggerFacade _logger;

        public StudentListViewModule(IUnityContainer container, IRegionManager regionManager, ILoggerFacade logger)
        {
            Container = container;
            RegionManager = regionManager;
            _logger = logger;
        }

        public void Initialize()
        {
            this._logger.Log("StudentListViewModule Initialize()", Category.Info, Priority.Medium);

            var studentListView = Container.Resolve<StudentListView>();
            RegionManager.Regions["StudentListViewModule"].Add(studentListView);
        }
    }
}
