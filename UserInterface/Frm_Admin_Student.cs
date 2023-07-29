using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
    public partial class Frm_Admin_Student : Form
    {
        DataStudentService dataStudentService = new DataStudentService();

        public Frm_Admin_Student()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool load = false;

            if (tBDni.Value <= 0)
            {
                MessageBox.Show("DNI invalido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tBFullName.Text))
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBoxButtons boton = MessageBoxButtons.OKCancel;
            DialogResult dialogResult = MessageBox.Show("Seguro que desea cargar los siguientes datos:\r\n" + "DNI: " + tBDni.Value + " Nombre: " + tBFullName.Text, "Estudiantes", boton, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.OK)
            {
                load = dialogResult == DialogResult.OK;
                if (load)
                {
                    int valor = (int)tBDni.Value;
                    var altastudent = dataStudentService.AddStudent(valor, tBFullName.Text);

                    if (altastudent != null)
                    {
                        MessageBox.Show("Estudiante creado exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El DNI ya se encuentra registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                this.Close();
            }

        }
    }
}
