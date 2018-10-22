using Ektra.Core;
using Ektra.Core.IRepositories;
using Ektra.Persistence.Repositories;

namespace Ektra.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IGigRepository Gigs { get; }
        public IGenreRepository Genres { get; }
        public IAttendanceRepository Attendances { get; }
        public IFollowingRepository Followings { get; }
        public IUserNotificationRepository UserNotifications { get; }
        public INotificationRepository Notifications { get; }
        public IApplicationUserRepository Users { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Gigs = new GigRepository(_context);
            Genres = new GenreRepository(_context);
            Attendances = new AttendanceRepository(_context);
            Followings = new FollowingRepository(_context);
            UserNotifications = new UserNotificationRepository(_context);
            Notifications = new NotificationRepository(_context);
            Users = new ApplicationUserRepository(_context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}