using MeetOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetOrganizer.DataAccess
{
    public class MeetOrganizerDbContext : DbContext
    {

        public MeetOrganizerDbContext() : base("MeetOrganizerDb")
        {

        }
        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }


}
