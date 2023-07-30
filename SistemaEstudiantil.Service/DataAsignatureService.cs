using AppSistemaEstudiantil.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace SistemaEstudiantil.Service
{
    public class DataAsignatureService
    {
        public Asignature AddAsignature(string fullNameTeacher, int codeAsignature, string nameAsignature)
        {
            // Convierte el JSON almacenado en una lista de objetos Asignature.
            List<Asignature> asignatures = ConvertJson();

            // Verifica si ya existe una asignatura con el mismo código.
            bool codeExists = asignatures.Any(s => s.CodeAsignature == codeAsignature);

            if (!codeExists)
            {
                // Si el código no existe, crea una nueva asignatura con la información proporcionada.
                Asignature asignature = new Asignature(fullNameTeacher, codeAsignature, nameAsignature);
                asignatures.Add(asignature); // Agrega la nueva asignatura a la lista existente.

                // Especifica la ruta del archivo JSON donde se almacenarán los datos actualizados.
                string rutaArchivo = @"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataAsignature.json";
                // Convierte la lista actualizada a JSON con formato legible y lo guarda en el archivo especificado.
                string json = JsonSerializer.Serialize(asignatures, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, json);

                // Devuelve la asignatura creada como resultado de la operación.
                return asignature;
            }
            // Si el código ya existe, se retorna 'null' para indicar que la operación no fue exitosa.
            return null;
        }

        public bool RemoveAsignature(int codeAsignature)
        {
            // Convierte el JSON almacenado en una lista de objetos Asignature.
            List<Asignature> asignatures = ConvertJson();

            // Busca la asignatura a eliminar en la lista, usando el código de asignatura como criterio.
            Asignature asignatureToRemove = asignatures.FirstOrDefault(s => s.CodeAsignature == codeAsignature);

            // Verifica si se encontró una asignatura con el código especificado.
            if (asignatureToRemove != null)
            {
                // Si se encontró la asignatura, se procede a eliminarla de la lista.
                asignatures.Remove(asignatureToRemove);

                // Especifica la ruta del archivo JSON donde se almacenarán los datos actualizados.
                string rutaArchivo = @"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataAsignature.json";
                // Convierte la lista actualizada a JSON con formato legible y lo guarda en el archivo especificado.
                string json = JsonSerializer.Serialize(asignatures, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, json);

            }
            // Se retorna 'false' para indicar que la operación no fue exitosa (no se encontró la asignatura o no se pudo guardar en el archivo).
            return false;
        }

        public List<Asignature> ConvertJson()
        {
            // Lee el contenido del archivo JSON y lo almacena en una variable llamada 'json'.
            string json = File.ReadAllText(@"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataAsignature.json");

            // Deserializa el contenido JSON en una lista de objetos Asignature usando el método 'JsonSerializer.Deserialize()'.
            List<Asignature> asignatures = JsonSerializer.Deserialize<List<Asignature>>(json);

            // Retorna la lista de objetos Asignature obtenida del JSON.
            return asignatures;

        }

    }
}
