using System.Collections.Generic;

namespace EventEaseApp.Services
{
    public class AttendanceService
    {
        private readonly Dictionary<int, List<string>> _eventAttendance = new();

        public void MarkAttendance(int eventId, string userName)
        {
            if (!_eventAttendance.ContainsKey(eventId))
            {
                _eventAttendance[eventId] = new List<string>();
            }

            if (!_eventAttendance[eventId].Contains(userName))
            {
                _eventAttendance[eventId].Add(userName);
            }
        }

        public List<string> GetAttendees(int eventId)
        {
            return _eventAttendance.ContainsKey(eventId) ? _eventAttendance[eventId] : new List<string>();
        }
    }
}