using System.Collections.Generic;
using Ektra.Core.Models;

namespace Ektra.Core.IRepositories
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetGenres();
    }
}