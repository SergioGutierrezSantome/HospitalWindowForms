using Hospital;
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

namespace HospitalFormWindowEdition
{
    public partial class ListaMedicos : Form
    {
        Hospital MiHospital;
        public ListaMedicos(Hospital hospital)
        {

            InitializeComponent();
            MiHospital = hospital;

        }
        private void CargarMedicos()
        {
         
            List<Medico> medicos = MiHospital.RepositorioMedicos.ObtenerTodos();

            listBox1.DataSource = null;
            listBox1.DataSource = medicos;
            listBox1.DisplayMember = "nombre";
            //dataGridViewMedicos.DataSource = medicos;

        }
      
        private void Form5_Load(object sender, EventArgs e)
        {
            CargarMedicos();
        }

        private void dataGridViewMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
