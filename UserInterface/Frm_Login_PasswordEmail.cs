using SistemaEstudiantil.Service;
using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserInterface
{
    public partial class Frm_Login_PasswordEmail : Form
    {
        SecurityService securityService = new SecurityService();
        public Frm_Login_PasswordEmail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var UserLoging = securityService.LoginSendEmail(textBox1.Text);


            if (UserLoging != null)
            {
                {
                    string correoEmisor = "carlosjguerrab17@gmail.com";
                    string contraseñaEmisor = "jecwaoolwxdwovuf";
                    string correoDestinatario = UserLoging.Email;
                    string asunto = "Datos de Usuario Sistema Estudiantil";
                    string cuerpo = "Su usuario es: " + UserLoging.Username + " y su contraseña es: " + UserLoging.Password;


                    MailMessage mensaje = new MailMessage(correoEmisor, correoDestinatario, asunto, cuerpo);


                    SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com", 587);
                    clienteSmtp.EnableSsl = true;
                    clienteSmtp.Credentials = new NetworkCredential(correoEmisor, contraseñaEmisor);

                    try
                    {
                        clienteSmtp.Send(mensaje);
                        MessageBox.Show("Correo enviado correctamente.");
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al enviar el correo: " + ex.Message);
                    }
                    finally
                    {
                        mensaje.Dispose();
                        clienteSmtp.Dispose();
                    }
                }
            }

            else
            {
                MessageBox.Show("El correo electronico no existe");
                textBox1.Text = string.Empty;
                this.Hide();
            }
        }
    }
}
