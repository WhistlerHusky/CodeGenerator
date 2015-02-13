using System;
using CodeGenerator.EventAggregation;
using DockingController;
using MenuModule.MenuEvents;
using MenuModule.ViewModel;

namespace MenuModule
{
    public static class MenuEventFactory
    {
        public static IMenuEvent CreateMenuEvent(MenuOption? menuOption, IDockController dockController)
        {
            IMenuEvent menuEvent = null;

            switch (menuOption)
            {
                case MenuOption.New:
                    menuEvent = new CreateNewFileMenuEvent(dockController);
                    break;
                case MenuOption.Save:
                    break;
                default:
                    new NotImplementedException();
                    break;
            }

            return menuEvent;
        }
    }
}
