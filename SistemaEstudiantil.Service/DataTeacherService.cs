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
    public class DataTeacherService
    {
        public Teacher AddTeacher(int Dni, string fullName, string specialty)
        {
            List<Teacher> teachers = new List<Teacher>();
            teachers = ConvertJson();
            bool dniExists = teachers.Any(s => s.DNITeacher == Dni);


            if ((!dniExists))
            {
                Teacher teacher = new Teacher(Dni, fullName, specialty);
                teachers.Add(teacher);

                string rutaArchivo = @"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataTeacher.json";
                string json = JsonSerializer.Serialize(teachers, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, json);

                return teacher;
            }            
            else
            {
                return null;
            }
        }

        public bool UpdateTeacher(int dni, string fullName, string specialty)
        {
            List<Teacher> teachers = ConvertJson();

            Teacher teacherToUpdate = teachers.FirstOrDefault(t => t.DNITeacher == dni);

            if (teacherToUpdate != null)
            {
                if (!string.IsNullOrEmpty(fullName))
                {
                    teacherToUpdate.FullName = fullName;
                }

                if (!string.IsNullOrEmpty(specialty))
                {
                    teacherToUpdate.Specialty = specialty;
                }

                string rutaArchivo = @"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataTeacher.json";
                string json = JsonSerializer.Serialize(teachers, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, json);

                return true;
            }

            return false;
        }

        public bool RemoveTeacher(int dni)
        {
            List<Teacher> teachers = ConvertJson();

            Teacher teacherToRemove = teachers.FirstOrDefault(s => s.DNITeacher == dni);

            if (teacherToRemove != null)
            {
                teachers.Remove(teacherToRemove);

                string rutaArchivo = @"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataTeacher.json";
                string json = JsonSerializer.Serialize(teachers, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, json);

                return true;
            }

            return false;
        }

        public List<Teacher> ConvertJson()
        {
            string json = File.ReadAllText(@"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataTeacher.json");

            List<Teacher> teachers = JsonSerializer.Deserialize<List<Teacher>>(json);

            return teachers;
        }

    }
}