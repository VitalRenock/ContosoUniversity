namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        // La propriété CourseID est une clé étrangère
        // La propriété de navigation correspondante est 'Course'.
        // La propriété peut contenir une seule entité 'Course'.
        public int CourseID { get; set; }

        // La propriété StudentID est une clé étrangère
        // La propriété de navigation correspondante est 'Student'.
        // La propriété peut contenir une seule entité 'Student'.
        public int StudentID { get; set; }

        // La propriété 'Grade' est une énumération.
        // Le point d’interrogation indique que la propriété accepte les valeurs NULL.
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}