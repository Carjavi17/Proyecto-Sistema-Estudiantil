using AppSistemaEstudiantil.Entities;
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
    public partial class Frm_Admin_DeleteTeacher : Form
    {
        DataTeacherService listTeacher = new DataTeacherService();

        private string fullName;
        private int dniTeacher;
        private string especialidad;
        public Frm_Admin_DeleteTeacher()
        {
            InitializeComponent();
            var teacherList = listTeacher.ConvertJson();

            foreach (var teacher in teacherList)
            {
                comboBox1.Items.Add(teacher);
                comboBox1.DisplayMember = "DNITeacher";
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var teacherSelect = (Teacher)comboBox1.SelectedItem;
                fullName = teacherSelect.FullName;
                dniTeacher = teacherSelect.DNITeacher;
                especialidad = teacherSelect.Specialty;
                label10.Text = fullName;
                label2.Text = especialidad;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ningun DNI seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBoxButtons boton = MessageBoxButtons.OKCancel;
            DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar los siguientes datos:\r\n" + "DNI: " + dniTeacher + " Nombre: " + fullName + " Especialidad: " + especialidad, "Profesores", boton, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.OK)
            {
                var removed = listTeacher.RemoveTeacher(dniTeacher);
                MessageBox.Show("Profesor eliminado exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
