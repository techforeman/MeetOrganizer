using Autofac;
using MeetOrganizer.DataAccess;
using MeetOrganizer.UI.Data;
using MeetOrganizer.UI.ViewModel;
using Prism.Events;

namespace MeetOrganizer.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            builder.RegisterType <MeetOrganizerDbContext>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<FriendDetailViewModel>().As<IFriendDetailViewModel>();
            builder.RegisterType<NavigationViewModel>().As<INavigationViewMode>();
            builder.RegisterType<LookupDataService>().AsImplementedInterfaces();
            builder.RegisterType<FriendDataService>().As<IFriendDataService>();
            return builder.Build();
        }
    }
}
