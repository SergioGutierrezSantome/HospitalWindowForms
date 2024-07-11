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

    public partial class AñadirPaciente : Form
    {
        Hospital MiHospital;
        public AñadirPaciente(Hospital hospital)
        {
            MiHospital = hospital;
            InitializeComponent();
            List<Medico> medicos = MiHospital.RepositorioMedicos.ObtenerTodos();

            comboBox5.DataSource = null;
            comboBox5.DataSource = medicos;
            comboBox5.DisplayMember = "nombre";

           
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medico medicoSeleccionado = (Medico)comboBox5.SelectedItem;
            if (medicoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un médico.");
                return;
            }
            Paciente NuevoPaciente = new Paciente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, medicoSeleccionado.DNI);
            MiHospital.RepositorioPaciente.Agregar(NuevoPaciente);
            MiHospital.RepositorioPersona.Agregar(NuevoPaciente);
            Close();
        }
    }
}
