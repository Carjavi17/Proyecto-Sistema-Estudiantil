using SistemaEstudiantil.Service;
using System;
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

namespace UserInterface
{
    public partial class Frm_Login_ChangePassword : Form
    {
        SecurityService securityService = new SecurityService();
        public Frm_Login_ChangePassword()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var UserLoging = securityService.LoginChangePassword(textBox1.Text, textBox2.Text, textBox3.Text);


            if (UserLoging != null)
            {
                MessageBox.Show("Cambio de contraseña efectuado con exito");
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                this.Hide();
            }

            else
            {
                MessageBox.Show("correo o contraseña invalidos");
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
            }
        }
    }
}
