using CodeGenerator.EventAggregation;
using DockingController;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.PubSubEvents;

namespace MenuModule.ViewModel
{
    public class MenuViewModel
    {
        private IEventAggregator _eventAggregator;
        private IDockController _dockController;
        public DelegateCommand<MenuOption?> MenuEventCommand { get; set; }
    
        public MenuViewModel(IEventAggregator eventAggregator, IDockController dockController)
        {
            _eventAggregator = eventAggregator;
            _dockController = dockController;

            MenuEventCommand = new DelegateCommand<MenuOption?>(MenuEventClicked);
        }

        private void MenuEventClicked(MenuOption? menuOption)
        {
            IMenuEvent menuEvent = MenuEventFactory.CreateMenuEvent(menuOption, _dockController);
            menuEvent.RunMenuEvent();
        }
    }
}
