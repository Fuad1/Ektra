using Ektra.Core;
using Ektra.Core.IRepositories;
using Ektra.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ektra.Persistence.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly IApplicationDbContext _context;

        public AttendanceRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Attendance> GetFutureAttendances(string userId)
        {
            return _context.Attendances
                .Where(a => a.AttendeeId == userId && a.Gig.DateTime > DateTime.Now)
                .ToList();
        }


        public Attendance GetAttendance(int gigId, string userId)
        {
            return _context.Attendances
                .FirstOrDefault(a => a.GigId == gigId && a.AttendeeId == userId);
        }


        public void Remove(Attendance attendance)
        {
            _context.Attendances.Remove(attendance);
        }

        public void Add(Attendance attendance)
        {
            _context.Attendances.Add(attendance);
        }
    }
}