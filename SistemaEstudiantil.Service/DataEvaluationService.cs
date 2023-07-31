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
        // Especifica la ruta del archivo JSON donde se almacenarán los datos actualizados.
        string rutaArchivo = @"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataEvaluation.json";
        public Evaluation AddEvaluation(string fullname, int Dni, int codeAsignature,string nameAsignature, int firstEvaluation, int secondEvaluation, int finalEvaluation,string fullNameTeacher)
        {
            // Inicializa la variable 'evaluation' con valor nulo.
            Evaluation evaluation = null;
            // Convierte el JSON almacenado en una lista de objetos Evaluation.
            List<Evaluation> evaluations = ConvertJson();

            // Verifica que 'fullname' y 'nameAsignature' no sean nulos.
            if (fullname != null && nameAsignature != null)
            {
                // Verifica si ya existe una evaluación para el estudiante ('fullname') y la asignatura ('nameAsignature').
                bool isDuplicate = evaluations.Any(e => e.Student.FullName == fullname && e.Asignature.NameAsignature == nameAsignature);
                // Si ya existe una evaluación duplicada, se retorna 'null'.
                if (isDuplicate)
                {
                    return null;
                }
                // Crea un nuevo objeto 'Student' con los datos proporcionados.
                Student student = new Student(Dni, fullname);
                // Crea un nuevo objeto 'Asignature' con los datos proporcionados.
                Asignature asignature = new Asignature(fullNameTeacher,codeAsignature, nameAsignature);
                // Crea un nuevo objeto 'Evaluation' con los datos proporcionados.
                Evaluation evaluation1 = new Evaluation(student, asignature, firstEvaluation, secondEvaluation, finalEvaluation);
                evaluations.Add(evaluation1);

                // Convierte la lista actualizada a JSON con formato legible y lo guarda en el archivo especificado.
                string json = JsonSerializer.Serialize(evaluations, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, json);
                // Asigna el objeto 'evaluation1' a la variable 'evaluation' para devolverlo como resultado de la operación.
                evaluation = evaluation1;
            }
            // Retorna la evaluación creada como resultado de la operación o 'null' si no se pudo agregar debido a un duplicado.
            return evaluation;
        }

        public List<Evaluation> ConvertJson()
        {
            // Lee el contenido del archivo JSON y lo almacena en una variable llamada 'json'.
            string json = File.ReadAllText(rutaArchivo);
            // Deserializa el contenido JSON en una lista de objetos Evaluation usando el método 'JsonSerializer.Deserialize()'.
            List<Evaluation> evaluations = JsonSerializer.Deserialize<List<Evaluation>>(json);
            // Retorna la lista de objetos Evaluation obtenida del JSON.
            return evaluations;

        }

    }
}
