using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Api.Models
{
    class ClassDay
    {
        public Venue Venue { get; set; }
        public List<Student> Attendencelist;
        public DateTime Date;
        public string Lesson;
    }
}
