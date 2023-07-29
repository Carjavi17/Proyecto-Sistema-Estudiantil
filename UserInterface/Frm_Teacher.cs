using AppSistemaEstudiantil.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using SistemaEstudiantil.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Properties;

namespace UserInterface
{
    public partial class Frm_Teacher : Form
    {
        DataStudentService listStudent = new DataStudentService();
        DataAsignatureService listAsignature = new DataAsignatureService();
        DataEvaluationService dataEvaluationService = new DataEvaluationService();

        private string fullName;
        private string fullNameStudent;
        private int dNIStudent;
        private string nameAsignature;
        private int codeAsignature;
        public Frm_Teacher(string fullName, string imageName)
        {
            InitializeComponent();
            var studentList = listStudent.ConvertJson();
            var asignatureList = listAsignature.ConvertJson();

            foreach (var student in studentList)
            {
                comboBox1.Items.Add(student);
                comboBox1.DisplayMember = "DNIStudent";
            }
            foreach (var asignature in asignatureList)
            {
                if (asignature.FullNameTeacher == fullName)
                {
                    comboBox3.Items.Add(asignature);
                    comboBox3.DisplayMember = "CodeAsignature";
                }
            }
            this.fullName = fullName;
            pictureBox2.Image = Image.FromFile(@"C:\Users\carlos\source\repos\Proyecto\UserInterface\Resources\" + imageName);
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var studentSelect = (Student)comboBox1.SelectedItem;
                fullNameStudent = studentSelect.FullName;
                dNIStudent = studentSelect.DNIStudent;
                label10.Text = fullNameStudent;
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                var asignatureSelect = (Asignature)comboBox3.SelectedItem;
                nameAsignature = asignatureSelect.NameAsignature;
                codeAsignature = asignatureSelect.CodeAsignature;
                label11.Text = nameAsignature;
            }
        }

        private void Frm_Teacher_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido " + fullName;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool load = false;

            if ((comboBox1.SelectedIndex == -1) || (comboBox3.SelectedIndex == -1))
            {
                MessageBox.Show("Debe seleccionar un campo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBoxButtons boton = MessageBoxButtons.OKCancel;           
            DialogResult dialogResult = MessageBox.Show("Seguro que desea cargar las siguientes evaluaciones:\r\n" + "Evaluacion 1: " + numericUpDown1.Value +" Evaluacion 2: " + numericUpDown2.Value +" Evaluacion 3: " + numericUpDown3.Value,"Evaluaciones",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.OK)
            {
                load = dialogResult == DialogResult.OK;
                if (load)
                {
                    int valor = (int)numericUpDown1.Value;
                    int valor1 = (int)numericUpDown2.Value;
                    int valor2 = (int)numericUpDown3.Value;
                    var altaEvaluation = dataEvaluationService.AddEvaluation(fullNameStudent, dNIStudent, codeAsignature, nameAsignature, valor, valor1, valor2, fullName);

                    if (altaEvaluation != null)
                    {
                        MessageBox.Show("Las notas fueron cargadas exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ya la nota fue cargada anteriormente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Frm_LaVieja vieja = new Frm_LaVieja();
            vieja.Show();
        }
    }
}
