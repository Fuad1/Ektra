using Ektra.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace Ektra.Persistence.EntityConfigurations
{
    public class NotificationConfiguration : EntityTypeConfiguration<Notification>
    {
        public NotificationConfiguration()
        {
            HasRequired(n => n.Gig);
        }
    }
}