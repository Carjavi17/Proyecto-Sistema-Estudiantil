using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaEstudiantil.Entities
{
    public class Evaluation
    {
        public Student Student { get; set; }
        public Asignature Asignature { get; set; }
        public int FirstEvaluation { get; set; }
        public int SecondEvaluation { get; set; }
        public int FinalEvaluation { get; set; }

        public Evaluation(Student student, Asignature asignature, int firstEvaluation, int secondEvaluation, int finalEvaluation)
        {
            Student = student;
            Asignature = asignature;
            FirstEvaluation = firstEvaluation;
            SecondEvaluation = secondEvaluation;
            FinalEvaluation = finalEvaluation;
        }


    }
}
