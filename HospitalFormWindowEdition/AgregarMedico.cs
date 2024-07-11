using Hospital;
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

namespace HospitalFormWindowEdition
{
    public partial class AgregarMedico : Form
    {
        Hospital MiHospital;
        public AgregarMedico(Hospital hospital)
        {
            MiHospital = hospital;
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medico NuevoMedico = new Medico(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            MiHospital.RepositorioMedicos.Agregar(NuevoMedico);
            MiHospital.RepositorioPersona.Agregar(NuevoMedico);
            Close();
        }
    }
}
