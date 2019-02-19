using MeetOrganizer.Model;
using MeetOrganizer.UI.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MeetOrganizer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase

    {



        public MainViewModel(INavigationViewMode navigationViewModel,
            IFriendDetailViewModel friendDetailViewModel)
        {
            NavigationViewModel = navigationViewModel;
            FriendDetailViewModel = friendDetailViewModel;

        }

        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
        }

        public INavigationViewMode NavigationViewModel { get; }
        public IFriendDetailViewModel FriendDetailViewModel { get; }

    }
}
