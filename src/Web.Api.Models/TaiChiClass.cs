using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Api.Models
{
    class TaiChiClass
    {
        public long Id { get; set; }
        public Venue Venue { get; set; }
        public List<Student> Students { get; set; }
        public HashSet<Days> DaysHeld { get; set; }

    }
}
