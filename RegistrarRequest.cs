using System;

namespace IDSCRegistrar.Models
{
    public class RegistrarRequest
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentID { get; set; }
        public string RequestType { get; set; }
        public string Description { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
