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
    public class DataStudentService
    {
        string rutaArchivo = @"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataStudent.json";
        public Student AddStudent(int dni, string fullName)
        {
            List<Student>  students = ConvertJson();
            bool dniExists = students.Any(s => s.DNIStudent == dni);

            if (!dniExists)
            {
                Student student = new Student(dni, fullName);
                students.Add(student);
  
                string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, json);

                return student;
            }
            else
            {
                return null;
            }
        }
        public bool RemoveStudent(int dni)
        {
            List<Student> students = ConvertJson();

            Student studentToRemove = students.FirstOrDefault(s => s.DNIStudent == dni);

            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);

                string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, json);

                return true;
            }

            return false;
        }

        public bool UpdateStudent(int dni, string fullName)
        {
            List<Student> students = ConvertJson();

            Student studentToUpdate = students.FirstOrDefault(s => s.DNIStudent == dni);
            if (studentToUpdate != null)
            {
                studentToUpdate.FullName = fullName;

                string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, json);

                return true;
            }

            return false;
        }

        public List<Student> ConvertJson()
        {
            string json = File.ReadAllText(rutaArchivo);

            List<Student> students = JsonSerializer.Deserialize<List<Student>>(json);

            return students;

        }
    }
}
