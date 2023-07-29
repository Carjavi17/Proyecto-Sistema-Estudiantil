namespace StudentSystem
{
    public class Asignature
    {
        public int CodeAsignature { get; set; }
        public string NameAsignature { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
        public List<Evaluation> Evaluation { get; set; }
        public double FinalNote { get; set; }


    }
}
