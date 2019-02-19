using MeetOrganizer.DataAccess;
using MeetOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetOrganizer.UI.Data
{
	public class FriendDataService : IFriendDataService
	{
        private Func<MeetOrganizerDbContext> _contextCreator;

        public FriendDataService(Func<MeetOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<Friend> GetByIdAsync(int friendId)
		{
            using (var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking().SingleAsync(f=>f.Id==friendId);
            }
		}
	}
}
