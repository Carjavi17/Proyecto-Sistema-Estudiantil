namespace AppSistemaEstudiantil.Entities
{
    public class Student
    {
        public int DNIStudent { get; set; }
        public string FullName { get; set; }

        public Student(int dniStudent, string fullName)
        {
            DNIStudent = dniStudent;
            FullName = fullName;
        }

    }
}
