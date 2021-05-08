using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        // La propriété 'Enrollments' est une propriété de navigation.
        // Une entité 'Course' peut être associée à un nombre quelconque d’entités 'Enrollment'.
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}