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
    public partial class AñadirAdministrativo : Form
    {
        Hospital MiHospital;
        public AñadirAdministrativo(Hospital hospital)
        {
            MiHospital = hospital;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrativo NuevoAdministrativo = new Administrativo(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            MiHospital.repositorioAdmin.Agregar(NuevoAdministrativo);
            MiHospital.RepositorioPersona.Agregar(NuevoAdministrativo);
            Close();
        }
    }
}
