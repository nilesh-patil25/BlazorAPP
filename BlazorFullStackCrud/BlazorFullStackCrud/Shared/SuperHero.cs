using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFullStackCrud.Shared
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Locality { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public int? Longitude { get; set; }
        public int? Latitude { get; set; }
        public string Contact { get; set; }
        public Guid? ContactId { get; set; }
        public DateTime? CreatedAtUtc { get; set; }
        public DateTime? UpdatedAtUtc { get; set; }
        public DateTime? DeletedAtUtc { get; set; }
        public string Email { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }
    }
}
