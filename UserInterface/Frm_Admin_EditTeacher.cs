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
    public partial class Frm_Admin_EditTeacher : Form
    {
        DataTeacherService listTeacher = new DataTeacherService();
        private string fullName;
        private int dniTeacher;
        private string specialty;

        public Frm_Admin_EditTeacher()
        {
            InitializeComponent();
            var teacherList = listTeacher.ConvertJson();

            foreach (var teacher in teacherList)
            {
                comboBox1.Items.Add(teacher);
                comboBox1.DisplayMember = "DNITeacher";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string name = tBFullName.Text;
            string specialty = textBox1.Text;

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ningun DNI seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(tBFullName.Text))
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBoxButtons boton = MessageBoxButtons.OKCancel;
            DialogResult dialogResult = MessageBox.Show("Seguro que desea actualizar los siguientes datos:\r\n" + "DNI: " + dniTeacher + " Nombre: " + name + " Especialidad: " + specialty, "Profesor", boton, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.OK)
            {
                var editTeacher = listTeacher.UpdateTeacher(dniTeacher, name, specialty);
                MessageBox.Show("Profesor actualizado exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var teacherSelect = (Teacher)comboBox1.SelectedItem;
                fullName = teacherSelect.FullName;
                dniTeacher = teacherSelect.DNITeacher;
                specialty = teacherSelect.Specialty;
                label10.Text = fullName;
                label2.Text = specialty;
            }
        }
    }
}
