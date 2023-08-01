using SistemaEstudiantil.Service;
using AppSistemaEstudiantil.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace UserInterface
{
    public partial class Frm_Admin_Teacher : Form
    {
        DataTeacherService dataTeacherService = new DataTeacherService();
        public Frm_Admin_Teacher()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {

            bool load = false;

            if (textbDNI.Value <= 0)
            {
                MessageBox.Show("DNI invalido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbFullName.Text))
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBoxButtons boton = MessageBoxButtons.OKCancel;
            DialogResult dialogResult = MessageBox.Show("Seguro que desea crear al profesor con los siguientes datos:\r\n" + "DNI: " + textbDNI.Value + " Nombre: " + tbFullName.Text, "Profesores", boton, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.OK)
            {
                load = dialogResult == DialogResult.OK;
                if (load)
                {
                    int valor = (int)textbDNI.Value;
                    var altaTeacher = dataTeacherService.AddTeacher(valor, tbFullName.Text, tbSpecialty.Text);

                    if (altaTeacher != null)
                    {
                        MessageBox.Show("Profesor creado exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
