using System.Collections.Generic;
using Ektra.Core.Models;

namespace Ektra.Core.IRepositories
{
    public interface IApplicationUserRepository
    {
        IEnumerable<ApplicationUser> GetArtistsFollowedBy(string userId);
    }
}