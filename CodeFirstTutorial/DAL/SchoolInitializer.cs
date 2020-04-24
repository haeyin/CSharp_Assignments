using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CodeFirstTutorial.Models;

namespace CodeFirstTutorial.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student{FirstName="Clare",LastName="Shin",EnrollmentDate=DateTime.Parse("2019-10-01")},
                new Student{FirstName="Collette",LastName="Jeong",EnrollmentDate=DateTime.Parse("2019-10-01")},
                new Student{FirstName="Phoebe",LastName="Song",EnrollmentDate=DateTime.Parse("2019-10-01")},
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
                new Course{CourseID=1030,Title="Mandarin 3",Credits=4,},
                new Course{CourseID=2010,Title="Korean 1",Credits=4,},
                new Course{CourseID=2050,Title="Korean 5",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=1030,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=2050,Grade=Grade.B},
                new Enrollment{StudentID=3,CourseID=2010,Grade=Grade.A}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
            //base.Seed(context);            
        }
    }
}