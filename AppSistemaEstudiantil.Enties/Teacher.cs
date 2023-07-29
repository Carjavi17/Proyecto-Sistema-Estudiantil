namespace AppSistemaEstudiantil.Entities
{
    public class Teacher
    {
        public string FullName { get; set; }

        public int DNITeacher { get; set; }

        public string Specialty { get; set; }

        public Teacher(int dniTeacher, string fullName, string specialty)
        {
            DNITeacher = dniTeacher;
            FullName = fullName;
            Specialty = specialty;
        }
    }

}
