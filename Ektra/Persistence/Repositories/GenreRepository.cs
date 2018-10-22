using Ektra.Core;
using Ektra.Core.IRepositories;
using Ektra.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ektra.Persistence.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly IApplicationDbContext _context;

        public GenreRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Genre> GetGenres()
        {
            return _context.Genres.ToList();
        }
    }
}