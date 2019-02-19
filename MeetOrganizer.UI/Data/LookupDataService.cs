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
    public class LookupDataService : IFriendLookupDataService
    {
        private Func<MeetOrganizerDbContext> _contextCreator;
        public LookupDataService(Func<MeetOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupItem>> GetFriendLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking()
                    .Select(f =>
                    new LookupItem
                    {
                        Id = f.Id,
                        DisplayMember = f.FirstName + " " + f.LastName
                    })
                .ToListAsync();
            }
        }
    }
}
