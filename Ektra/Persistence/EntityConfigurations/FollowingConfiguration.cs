using Ektra.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace Ektra.Persistence.EntityConfigurations
{
    public class FollowingConfiguration : EntityTypeConfiguration<Following>
    {
        public FollowingConfiguration()
        {
            //Property(f => f.FollowerId)
            //    .HasColumnOrder(1);

            //Property(f => f.FolloweeId)
            //    .HasColumnOrder(2);

            HasKey(f => new { f.FollowerId, f.FolloweeId });
        }
    }
}