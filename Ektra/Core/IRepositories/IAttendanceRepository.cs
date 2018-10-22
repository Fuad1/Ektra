using Ektra.Core.Models;
using System.Collections.Generic;

namespace Ektra.Core.IRepositories
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetFutureAttendances(string userId);
        Attendance GetAttendance(int gigId, string userId);
        void Remove(Attendance attendance);
        void Add(Attendance attendance);
    }
}