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

namespace HospitalFormWindowEdition
{
    public partial class ListPersonal : Form
    {
        Hospital MiHospital;

        public ListPersonal(Hospital hospital)
        {
            InitializeComponent();
            MiHospital = hospital;
        }

        private void ListPersonal_Load(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Medico> medico = MiHospital.RepositorioMedicos.ObtenerTodos();
            listBox1.DataSource = null;
            listBox1.DataSource = medico;
            listBox1.DisplayMember = "ToString";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Paciente> paciente = MiHospital.RepositorioPaciente.ObtenerTodos();
            listBox1.DataSource = null;
            listBox1.DataSource = paciente;
            listBox1.DisplayMember = "ToString";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           List<Administrativo> adminstrativo = MiHospital.RepositorioAdmin.ObtenerTodos();
            listBox1.DataSource = null;
            listBox1.DataSource = adminstrativo;
            listBox1.DisplayMember = "ToString";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
