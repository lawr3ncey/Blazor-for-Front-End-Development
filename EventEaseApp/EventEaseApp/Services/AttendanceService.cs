using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    /// <summary>
    /// Servicio sencillo en memoria para gestionar registros de asistencia.
    /// En una app real se mapearía a backend/API o almacenamiento persistente.
    /// </summary>
    public class AttendanceService
    {
        // Concurrent dictionary por eventId -> lista de registros
        private readonly ConcurrentDictionary<int, List<AttendanceRecord>> store = new();

        public AttendanceService()
        {
        }

        public AttendanceRecord AddRecord(int eventId, string name, string email, bool isPresent = false, string status = "registered")
        {
            var rec = new AttendanceRecord
            {
                EventId = eventId,
                Name = name,
                Email = email,
                IsPresent = isPresent,
                Status = status,
                CreatedAt = DateTime.UtcNow
            };

            var list = store.GetOrAdd(eventId, _ => new List<AttendanceRecord>());
            lock (list)
            {
                list.Add(rec);
            }

            return rec;
        }

        public IEnumerable<AttendanceRecord> GetAttendees(int eventId)
        {
            if (store.TryGetValue(eventId, out var list))
            {
                lock (list) { return list.OrderBy(r => r.CreatedAt).ToList(); }
            }

            return Enumerable.Empty<AttendanceRecord>();
        }

        public int GetCount(int eventId)
        {
            if (store.TryGetValue(eventId, out var list))
            {
                lock (list) { return list.Count; }
            }

            return 0;
        }

        public bool MarkPresent(Guid recordId)
        {
            foreach (var kv in store)
            {
                var list = kv.Value;
                lock (list)
                {
                    var rec = list.FirstOrDefault(r => r.Id == recordId);
                    if (rec != null)
                    {
                        rec.IsPresent = true;
                        rec.Status = "present";
                        return true;
                    }
                }
            }

            return false;
        }

        public bool RemoveRecord(Guid recordId)
        {
            foreach (var kv in store)
            {
                var list = kv.Value;
                lock (list)
                {
                    var rec = list.FirstOrDefault(r => r.Id == recordId);
                    if (rec != null)
                    {
                        rec.Status = "cancelled";
                        list.Remove(rec);
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
