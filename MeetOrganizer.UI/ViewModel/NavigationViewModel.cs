using MeetOrganizer.Model;
using MeetOrganizer.UI.Data;
using MeetOrganizer.UI.Event;
using Prism.Events;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace MeetOrganizer.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase, INavigationViewMode
    {
        private IFriendLookupDataService _friendLookupService;
        private readonly IEventAggregator _eventAggregator;

        public NavigationViewModel(IFriendLookupDataService friendLookupService,
            IEventAggregator eventAggregator )
        {
            _friendLookupService = friendLookupService;
            Friends = new ObservableCollection<LookupItem>();
            _eventAggregator = eventAggregator;

        }

        public async Task LoadAsync()
        {
            var lookup = await _friendLookupService.GetFriendLookupAsync();
            Friends.Clear();
            foreach (var item in lookup)
            {
                Friends.Add(item);
            }
        }

        public ObservableCollection<LookupItem> Friends { get; set; }
        private LookupItem _selectedFriend;


        public LookupItem  SelectedFriend
        {
            get { return _selectedFriend; }
            set
            {
                _selectedFriend = value;
                OnPropertyChanged();
                if (_selectedFriend!=null)
                {
                    _eventAggregator.GetEvent<OpenFriendDetailViewEvent>().Publish(_selectedFriend.Id);
                }


            }
        }

    }
}
