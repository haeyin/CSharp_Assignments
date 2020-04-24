using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Clare" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}