using System.Threading.Tasks;

namespace MeetOrganizer.UI.ViewModel
{
    public interface IFriendDetailViewModel
    {
        Task LoadAsync(int friendId);
    }
}