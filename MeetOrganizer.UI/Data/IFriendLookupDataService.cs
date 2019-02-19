using System.Collections.Generic;
using System.Threading.Tasks;
using MeetOrganizer.Model;

namespace MeetOrganizer.UI.Data
{
    public interface IFriendLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetFriendLookupAsync();
    }
}