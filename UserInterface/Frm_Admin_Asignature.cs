using AppSistemaEstudiantil.Entities;
using SistemaEstudiantil.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserInterface
{
    public partial class Frm_Admin_Asignature : Form
    {
        DataAsignatureService dataAsignatureService = new DataAsignatureService();
        DataTeacherService listTeacher = new DataTeacherService();

        public Frm_Admin_Asignature()
        {
            InitializeComponent();
            LoadList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (numBoxCode.Value <= 0)
            {
                MessageBox.Show("Codigo de asignatura invalido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBoxNameAsig.Text))
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            MessageBoxButtons boton = MessageBoxButtons.OKCancel;
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea guardar los datos seleccionados?", "Asignatura", boton, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.OK)
            {
                int valor = (int)numBoxCode.Value;
                var fullNameTeacher = comboBox1.SelectedItem.ToString();
                var altasasignature = dataAsignatureService.AddAsignature(fullNameTeacher, valor, txtBoxNameAsig.Text);

                if (altasasignature != null)
                {
                    MessageBox.Show("Asignatura Creada");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El codigo de asignatura ya existe");
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        public void LoadList()
        {
            var teacherList = listTeacher.ConvertJson();
            foreach (var teacher in teacherList)
            {
                comboBox1.Items.Add(teacher.FullName);
            }
        }
    }
}
