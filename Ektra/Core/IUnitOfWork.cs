using Ektra.Core.IRepositories;

namespace Ektra.Core
{
    public interface IUnitOfWork
    {
        IGigRepository Gigs { get; }
        IGenreRepository Genres { get; }
        IAttendanceRepository Attendances { get; }
        IFollowingRepository Followings { get; }
        IUserNotificationRepository UserNotifications { get; }
        INotificationRepository Notifications { get; }
        IApplicationUserRepository Users { get; }
        void Complete();
    }
}