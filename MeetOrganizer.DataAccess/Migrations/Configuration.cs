namespace MeetOrganizer.DataAccess.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MeetOrganizer.DataAccess.MeetOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MeetOrganizer.DataAccess.MeetOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend { FirstName = "Grzegorz", LastName = "Kowalski" },
                new Friend { FirstName = "Janek", LastName = "Brzęczyszczykiewicz" },
                new Friend { FirstName = "Bartek", LastName = "Kuźmik" },
                new Friend { FirstName = "Jakub", LastName = "Toldarczyk" },
                new Friend { FirstName = "Kamil", LastName = "Bułczański" }
                );
        }
    }
}
