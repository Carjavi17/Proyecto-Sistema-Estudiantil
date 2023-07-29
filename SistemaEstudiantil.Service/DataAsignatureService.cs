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
            List<Asignature> asignatures = ConvertJson();
            bool codeExists = asignatures.Any(s => s.CodeAsignature == codeAsignature);

            if (!codeExists)
            {
                Asignature asignature = new Asignature(fullNameTeacher, codeAsignature, nameAsignature);
                asignatures.Add(asignature);

                string rutaArchivo = @"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataAsignature.json";
                string json = JsonSerializer.Serialize(asignatures, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, json);

                return asignature;
            }

            return null;
        }

        public bool RemoveAsignature(int codeAsignature)
        {
            List<Asignature> asignatures = ConvertJson();

            Asignature asignatureToRemove = asignatures.FirstOrDefault(s => s.CodeAsignature == codeAsignature);

            if (asignatureToRemove != null)
            {
                asignatures.Remove(asignatureToRemove);

                string rutaArchivo = @"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataAsignature.json";
                string json = JsonSerializer.Serialize(asignatures, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, json);

            }
            
            return false;
        }

        public List<Asignature> ConvertJson()
        {
            string json = File.ReadAllText(@"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataAsignature.json");

            List<Asignature> asignatures = JsonSerializer.Deserialize<List<Asignature>>(json);

            return asignatures;

        }

    }
}
