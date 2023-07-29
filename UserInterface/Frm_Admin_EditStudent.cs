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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserInterface
{
    public partial class Frm_Admin_EditStudent : Form
    {
        DataStudentService listStudent = new DataStudentService();

        private string fullName;
        private int dniStudent;
        public Frm_Admin_EditStudent()
        {

            InitializeComponent();
            var studentList = listStudent.ConvertJson();

            foreach (var student in studentList)
            {
                comboBox1.Items.Add(student);
                comboBox1.DisplayMember = "DNIStudent";
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var studentSelect = (Student)comboBox1.SelectedItem;
                fullName = studentSelect.FullName;
                dniStudent = studentSelect.DNIStudent;
                label10.Text = fullName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = tBFullName.Text;

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ningun DNI seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tBFullName.Text))
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBoxButtons boton = MessageBoxButtons.OKCancel;
            DialogResult dialogResult = MessageBox.Show("Seguro que desea actualizar los siguientes datos:\r\n" + "DNI: " + dniStudent + " Nombre: " + name, "Estudiantes", boton, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.OK)
            {
                var editstudent = listStudent.UpdateStudent(dniStudent, name);
                MessageBox.Show("Estudiante actualizado exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
