using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFSample
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public int? GradeId { get; set; }

        public virtual Grade Grade { get; set; }

        //public virtual ICollection<Course> Courses { get; set; }

    }
}