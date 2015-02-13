using CodeGenerator.EventAggregation;
using DockingController;
using Microsoft.Practices.Prism.PubSubEvents;

namespace TextEditorModule
{
    /// <summary>
    /// Interaction logic for TextWindowModuleView.xaml
    /// </summary>
    public class TextEditorModuleEventAggregation
    {
        private IEventAggregator _eventAggregator;
        private SubscriptionToken _subscriptionToken;
        private IDockController _dockController;

        public TextEditorModuleEventAggregation(IEventAggregator eventAggregator, IDockController dockController)
        {
            _eventAggregator = eventAggregator;
            _dockController = dockController;

            var createNewFile = _eventAggregator.GetEvent<MenuSelectEvent>();

            if (_subscriptionToken != null)
            {
                createNewFile.Unsubscribe(_subscriptionToken);
            }

            _subscriptionToken = createNewFile.Subscribe(MenuSelecteEventHandler, ThreadOption.UIThread, false);
        }

        private void MenuSelecteEventHandler(MenuOption menuEvent)
        {
        }
    }
}
