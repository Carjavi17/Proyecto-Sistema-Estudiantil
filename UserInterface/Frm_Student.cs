using SistemaEstudiantil.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{

    public partial class Frm_Student : Form
    {
        SecurityService securityService = new SecurityService();

        private string fullName;
        public Frm_Student(string fullName, string imageName)
        {
            InitializeComponent();
            this.fullName = fullName;
            pictureBox2.Image = Image.FromFile(@"C:\Users\carlos\source\repos\Proyecto\UserInterface\Resources\" + imageName);
        }

        private void Frm_Student_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido " + fullName;
        }
        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Student_Note frmStNo = new Frm_Student_Note(fullName);
            frmStNo.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_LaCulebrita frmLaCulebrita = new Frm_LaCulebrita();
            frmLaCulebrita.Show();
        }
    }
}
