using Ektra.Core.Models;
using System.Collections.Generic;

namespace Ektra.Core.IRepositories
{
    public interface IFollowingRepository
    {
        Following GetFollowing(string artistId, string userId);
        IEnumerable<ApplicationUser> GetFollowees(string userId);
        void Add(Following following);
        void Remove(Following following);
    }
}