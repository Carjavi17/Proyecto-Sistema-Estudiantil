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
    public partial class Frm_Admin_DeleteAsignature : Form
    {
        DataAsignatureService listAsignature = new DataAsignatureService();

        private int codeAsignature;
        private string nameAsignature;

        public Frm_Admin_DeleteAsignature()
        {
            InitializeComponent();
            var asignatureList = listAsignature.ConvertJson();

            foreach (var asignature in asignatureList)
            {
                comboBox1.Items.Add(asignature);
                comboBox1.DisplayMember = "CodeAsignature";
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var asignatureSelected = (Asignature)comboBox1.SelectedItem;
                nameAsignature = asignatureSelected.NameAsignature;
                codeAsignature = asignatureSelected.CodeAsignature;
                label10.Text = nameAsignature;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ningun codigo seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBoxButtons boton = MessageBoxButtons.OKCancel;
            DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar los siguientes datos:\r\n" + "Codigo: " + codeAsignature + " Nombre: " + nameAsignature, "Asignaturas", boton, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.OK)
            {
                var removedAsignature = listAsignature.RemoveAsignature(codeAsignature);
                MessageBox.Show("Asignatura eliminada exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
