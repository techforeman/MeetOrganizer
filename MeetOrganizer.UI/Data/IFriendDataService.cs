using System.Collections.Generic;
using MeetOrganizer.Model;
using System.Threading.Tasks;

namespace MeetOrganizer.UI.Data
{
	public interface IFriendDataService
	{
        Task<Friend> GetByIdAsync(int friendId);

    }
}