using System.Collections.Generic;
using System.Linq;

namespace IDSCRegistrar.Models
{
    public static class FakeRequestRepository
    {
        private static List<RegistrarRequest> _requests = new List<RegistrarRequest>();
        private static int _nextId = 1;

        public static List<RegistrarRequest> GetAll() => _requests;

        public static RegistrarRequest Get(int id) => _requests.FirstOrDefault(r => r.Id == id);

        public static void Add(RegistrarRequest request)
        {
            request.Id = _nextId++;
            _requests.Add(request);
        }

        public static void Update(RegistrarRequest request)
        {
            var old = Get(request.Id);
            if (old != null)
            {
                old.StudentName = request.StudentName;
                old.StudentID = request.StudentID;
                old.RequestType = request.RequestType;
                old.Description = request.Description;
                old.RequestDate = request.RequestDate;
            }
        }

        public static void Delete(int id)
        {
            var r = Get(id);
            if (r != null)
                _requests.Remove(r);
        }
    }
}
