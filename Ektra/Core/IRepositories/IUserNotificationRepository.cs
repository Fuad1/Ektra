using Ektra.Core.Models;
using System.Collections.Generic;

namespace Ektra.Core.IRepositories
{
    public interface IUserNotificationRepository
    {
        IEnumerable<UserNotification> GetUserNotificationsFor(string userId);
    }
}