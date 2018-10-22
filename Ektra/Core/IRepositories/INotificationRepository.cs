using System.Collections.Generic;
using Ektra.Core.Models;

namespace Ektra.Core.IRepositories
{
    public interface INotificationRepository
    {
        IEnumerable<Notification> GetNewNotificationsFor(string userId);
    }
}