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
    public partial class AppPrincipal : Form
    {
        Hospital MiHospital = new Hospital();
        public AppPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarMedico form2 = new AgregarMedico(MiHospital);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Medico> medico = MiHospital.RepositorioMedicos.ObtenerTodos();
            if (medico.Count > 0)
            {
                AñadirPaciente form3 = new AñadirPaciente(MiHospital);
                form3.Show();
            }
            else
            {
                MessageBox.Show("No hay Medicos");
            }
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Medico> medico = MiHospital.RepositorioMedicos.ObtenerTodos();
            if (medico.Count > 0)
            {
                ListaMedicos form5 = new ListaMedicos(MiHospital);
                form5.Show();
            }
            else
            {
                MessageBox.Show("No hay Medicos");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                AñadirAdministrativo form4 = new AñadirAdministrativo(MiHospital);
                form4.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Medico> medico = MiHospital.RepositorioMedicos.ObtenerTodos();
            if (medico.Count > 0)
            {
                FiltroPacienteMedico form6 = new FiltroPacienteMedico(MiHospital);
                form6.Show();
            }
            else
            {
                MessageBox.Show("No hay Medicos");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Paciente> paciente = MiHospital.RepositorioPaciente.ObtenerTodos();
            if (paciente.Count > 0)
            {
                EliminarPaciente EliminarPacientes = new EliminarPaciente(MiHospital);
                EliminarPacientes.Show();
            }
            else
            {
                MessageBox.Show("No hay Pacientes");
            }
        }

       

        private void button7_Click_1(object sender, EventArgs e)
        {
            ListPersonal ListaPersonal = new ListPersonal(MiHospital);
            ListaPersonal.Show();
        }
    }
}
