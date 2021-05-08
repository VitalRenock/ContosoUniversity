using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        // Clé primaire
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        // Enrollments est une propriété de navigation.
        // Les propriétés de navigation contiennent d’autres entités qui sont associées à cette entité.
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}