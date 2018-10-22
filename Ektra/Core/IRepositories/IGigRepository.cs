using Ektra.Core.Models;
using System.Collections.Generic;

namespace Ektra.Core.IRepositories
{
    public interface IGigRepository
    {
        Gig GetGig(int gigId);
        Gig GetGigWithAttendances(int gigId);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        IEnumerable<Gig> GetUpComingGigsByArtist(string userId);
        IEnumerable<Gig> GetUpComingGigs();
        void Add(Gig gig);
    }
}