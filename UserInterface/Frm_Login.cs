using AppSistemaEstudiantil.Entities;
using SistemaEstudiantil.Service;

namespace UserInterface
{
    public partial class Frm_Login : Form
    {
        SecurityService securityService = new SecurityService();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var UserLoging = securityService.Login(textBox1.Text, textBox2.Text);


            if (UserLoging != null)
            {
                if (UserLoging.Access == "Administrator")
                {
                    Frm_Administrator frmadm = new Frm_Administrator(UserLoging.FullName, UserLoging.ImageName);
                    frmadm.Show();
                    this.Hide();
                }
                if (UserLoging.Access == "Student")
                {
                    Frm_Student frms = new Frm_Student(UserLoging.FullName, UserLoging.ImageName);
                    frms.Show();
                    this.Hide();
                }
                if (UserLoging.Access == "Teacher")
                {
                    Frm_Teacher frmt = new Frm_Teacher(UserLoging.FullName, UserLoging.ImageName);
                    frmt.Show();
                    this.Hide();
                }
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Login_PasswordEmail frmLPe = new Frm_Login_PasswordEmail();
            frmLPe.Show();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Login_ChangePassword frmLCP = new Frm_Login_ChangePassword();
            frmLCP.Show();
        }
    }
}