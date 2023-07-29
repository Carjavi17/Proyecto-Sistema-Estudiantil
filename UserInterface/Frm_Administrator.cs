using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSistemaEstudiantil.Entities;
using SistemaEstudiantil.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserInterface
{

    public partial class Frm_Administrator : Form
    {
        private string fullName;

        public Frm_Administrator(string fullName, string imageName)
        {
            InitializeComponent();
            this.fullName = fullName;

        }

        private void Frm_Administrator_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido " + fullName;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void newAsignatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Admin_Asignature frmAdmA = new Frm_Admin_Asignature();
            frmAdmA.Show();
        }

        private void newTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Admin_Teacher frmAdmT = new Frm_Admin_Teacher();
            frmAdmT.Show();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Admin_Student frmAdmS = new Frm_Admin_Student();
            frmAdmS.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Frm_LaVieja vieja = new Frm_LaVieja();
            vieja.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_LaCulebrita frmLaCulebrita = new Frm_LaCulebrita();
            frmLaCulebrita.Show();
        }

        private void borrarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Admin_DeleteStudent frmDeleteStudent = new Frm_Admin_DeleteStudent();
            frmDeleteStudent.Show();
        }

        private void borrarProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Admin_DeleteTeacher frmDeleteTeacher = new Frm_Admin_DeleteTeacher();
            frmDeleteTeacher.Show();
        }

        private void editarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Admin_EditStudent frmEditStudent = new Frm_Admin_EditStudent();
            frmEditStudent.Show();
        }

        private void editarProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Admin_EditTeacher frmEditTeacher = new Frm_Admin_EditTeacher();
            frmEditTeacher.Show();
        }

        private void borrarAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Admin_DeleteAsignature frmDeleteAsignature = new Frm_Admin_DeleteAsignature();
            frmDeleteAsignature.Show();
        }
    }
}
