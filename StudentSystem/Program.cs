namespace StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> usuarios = new List<Usuario>();

            usuarios.Add(new Usuario("Administrador", "Carlos Guerra", "carlos", "123"));
            usuarios.Add(new Usuario("Administrador", "Mizael Medina", "mizael", "123"));

            using (StreamWriter archivo = new StreamWriter("admin.txt"))
            {
                foreach (Usuario usuario in usuarios)
                {
                    string linea = $"{usuario.Type},{usuario.FullName},{usuario.Username},{usuario.Password}";
                    archivo.WriteLine(linea);
                }
            }

            List<Usuario> usuarios1 = new List<Usuario>();

            string rutaArchivo = @"C:\Users\carlos\source\repos\Proyecto\SistemaEstudiantil.Service\DataUser\DataAdmin.txt";

            using (StreamReader archivo1 = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = archivo1.ReadLine()) != null)
                {
                    string[] partes = linea.Split(',');

                    if (partes.Length == 4)
                    {
                        string tipo = partes[0];
                        string nombreApellido = partes[1];
                        string username = partes[2];
                        string contraseña = partes[3];

                        usuarios1.Add(new Usuario(tipo, nombreApellido, username, contraseña));
                    }
                }
            }

            foreach (var i in usuarios1)
            {
                Console.WriteLine(i.FullName);
            }





            }
    }
}