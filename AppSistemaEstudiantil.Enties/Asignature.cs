namespace AppSistemaEstudiantil.Entities
{
    public class Asignature
    {
        public string FullNameTeacher { get; set; }
        public int CodeAsignature { get; set; }
        public string NameAsignature { get; set; }

        public Asignature(string fullNameTeacher, int codeAsignature, string nameAsignature)
        {
            FullNameTeacher = fullNameTeacher;
            CodeAsignature = codeAsignature;
            NameAsignature = nameAsignature;
        }

    }
}
