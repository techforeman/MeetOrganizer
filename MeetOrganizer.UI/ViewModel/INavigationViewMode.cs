using System.Threading.Tasks;

namespace MeetOrganizer.UI.ViewModel
{
    public interface INavigationViewMode
    {
        Task LoadAsync();
    }
}