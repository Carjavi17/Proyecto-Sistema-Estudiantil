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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.Xml;

namespace UserInterface
{
    public partial class Frm_Student_Note : Form
    {
        DataEvaluationService dataEvaluationService = new DataEvaluationService();
        private string fullName;
        public Frm_Student_Note(string fullName)
        {
            InitializeComponent();
            this.fullName = fullName;
            CargarNotas();
        }
        private void CargarNotas()
        {
            listView1.View = View.Details;

            listView1.Columns.Add("Nombre de Asignatura", 200);
            listView1.Columns.Add("Primera Evaluacion", 180);
            listView1.Columns.Add("Segunda Evaluacion", 180);
            listView1.Columns.Add("Evaluacion Final", 180);

            List<Evaluation> datos = dataEvaluationService.ConvertJson();

            foreach (Evaluation eval in datos)
            {
                if (eval.Student.FullName == fullName)
                {
                    ListViewItem item = new ListViewItem(eval.Asignature.NameAsignature);
                    item.SubItems.Add(eval.FirstEvaluation.ToString());
                    item.SubItems.Add(eval.SecondEvaluation.ToString());
                    item.SubItems.Add(eval.FinalEvaluation.ToString());

                    listView1.Items.Add(item);
                }

            }
        }

        private void Frm_Student_Note_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido " + fullName;
        }
    }
}
