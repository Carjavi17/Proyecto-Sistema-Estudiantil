using AppSistemaEstudiantil.Entities;
using System.Data;
using System.IO;

namespace SistemaEstudiantil.Service
{
    public class SecurityService
    {
        public Usuario Login(string use, string pas)
        {
            List<Usuario> usuarios = new List<Usuario>();

            Usuario userFound = null;

            string rutaArchivo = @"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataAdmin.txt";

            try
            {
                using (StreamReader archivo1 = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = archivo1.ReadLine()) != null)
                    {
                        string[] partes = linea.Split(',');

                        if (partes.Length == 6)
                        {
                            string access = partes[0];
                            string fullName = partes[1];
                            string username = partes[2];
                            string password = partes[3];
                            string email = partes[4];
                            string imagename = partes[5];

                            usuarios.Add(new Usuario(access, fullName, username, password, email, imagename));
                        }
                    }
                }

                foreach (var i in usuarios)
                {
                    if (use == i.Username && pas == i.Password)
                    {
                        userFound = new Usuario(i.Access, i.FullName, i.Username, i.Password, i.Email, i.ImageName);
                        break;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: Archivo no encontrado: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error al leer el archivo: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al realizar el inicio de sesión: " + ex.Message);
            }

            return userFound;
        }

        public Usuario LoginSendEmail(string emailSend)
        {
            List<Usuario> usuarios = new List<Usuario>();

            Usuario userFound = null;

            string rutaArchivo = @"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataAdmin.txt";

            try
            {
                using (StreamReader archivo1 = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = archivo1.ReadLine()) != null)
                    {
                        string[] partes = linea.Split(',');

                        if (partes.Length == 6)
                        {
                            string access = partes[0];
                            string fullName = partes[1];
                            string username = partes[2];
                            string password = partes[3];
                            string email = partes[4];
                            string imagename = partes[5];

                            usuarios.Add(new Usuario(access, fullName, username, password, email, imagename));
                        }
                    }
                }

                foreach (var i in usuarios)
                {
                    if (emailSend == i.Email)
                    {
                        userFound = new Usuario(i.Access, i.FullName, i.Username, i.Password, i.Email, i.ImageName);
                        break;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: Archivo no encontrado: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error al leer el archivo: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al realizar el inicio de sesión: " + ex.Message);
            }

            return userFound;
        }

        public Usuario LoginChangePassword(string emailSend, string oldPassword, string newPassword)
        {
            List<Usuario> usuarios = new List<Usuario>();

            Usuario userFound = null;

            string rutaArchivo = @"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataAdmin.txt";
            try
            {
                using (StreamReader archivo1 = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = archivo1.ReadLine()) != null)
                    {
                        string[] partes = linea.Split(',');

                        if (partes.Length == 6)
                        {
                            string access = partes[0];
                            string fullName = partes[1];
                            string username = partes[2];
                            string password = partes[3];
                            string email = partes[4];
                            string imagename = partes[5];

                            usuarios.Add(new Usuario(access, fullName, username, password, email, imagename));
                        }
                    }
                }

                foreach (var i in usuarios)
                {
                    if (i.Email == emailSend && i.Password == oldPassword)
                    {
                        i.Password = newPassword;
                        userFound = i;
                        break;
                    }
                }
                using (StreamWriter archivo2 = new StreamWriter(rutaArchivo))
                {
                    foreach (var usuario in usuarios)
                    {
                        string linea = $"{usuario.Access},{usuario.FullName},{usuario.Username},{usuario.Password},{usuario.Email},{usuario.ImageName}";
                        archivo2.WriteLine(linea);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: Archivo no encontrado: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error al leer o escribir en el archivo: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al realizar el inicio de sesión: " + ex.Message);
            }

            return userFound;
        }
    }
}