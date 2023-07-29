using AppSistemaEstudiantil.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SistemaEstudiantil.Service
{
    public class DataEvaluationService
    {
        public Evaluation AddEvaluation(string fullname, int Dni, int codeAsignature,string nameAsignature, int firstEvaluation, int secondEvaluation, int finalEvaluation,string fullNameTeacher)
        {
            Evaluation evaluation = null;
            List<Evaluation> evaluations = ConvertJson();

            if (fullname != null && nameAsignature != null)
            {
                bool isDuplicate = evaluations.Any(e => e.Student.FullName == fullname && e.Asignature.NameAsignature == nameAsignature);
                if (isDuplicate)
                {
                    return null;
                }

                Student student = new Student(Dni, fullname);
                Asignature asignature = new Asignature(fullNameTeacher,codeAsignature, nameAsignature);

                Evaluation evaluation1 = new Evaluation(student, asignature, firstEvaluation, secondEvaluation, finalEvaluation);
                evaluations.Add(evaluation1);

                string rutaArchivo = @"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataEvaluation.json";
                string json = JsonSerializer.Serialize(evaluations, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, json);
                evaluation = evaluation1;
            }

            return evaluation;
        }

        public List<Evaluation> ConvertJson()
        {
            try
            {
                string json = File.ReadAllText(@"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataEvaluation.json");

                List<Evaluation> evaluations = JsonSerializer.Deserialize<List<Evaluation>>(json);

                return evaluations;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: Archivo JSON no encontrado: " + ex.Message);
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error al deserializar el archivo JSON: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al convertir JSON: " + ex.Message);
            }

            return null;
        }

    }
}
