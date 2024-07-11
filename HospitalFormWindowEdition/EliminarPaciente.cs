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
    public partial class EliminarPaciente : Form
    {
        Hospital MiHospital;
        public EliminarPaciente(Hospital hospital)
        {
            InitializeComponent();
            MiHospital = hospital;
            CargarDatos();
        }

        private void CargarDatos()
        {
            listBox1.DataSource = null;
            List<Paciente> paciente = MiHospital.RepositorioPaciente.ObtenerTodos();
            listBox1.DataSource = paciente;
            listBox1.DisplayMember = "ToString";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                List<string> PacientesEliminados = new List<string>();

                List<Paciente> pacientes = MiHospital.RepositorioPaciente.ObtenerTodos();
                foreach (Paciente paciente in listBox1.SelectedItems.Cast<Paciente>().ToList())
                {
                    PacientesEliminados.Add(paciente.nombre);
                    MiHospital.RepositorioPaciente.Eliminar(paciente.DNI);


                }
                PacientesEliminados.ToString();
                listBox1.DataSource = null;
                listBox1.DataSource = pacientes;
                EliminarPacientes(PacientesEliminados);
            }
            else
            {
                MessageBox.Show("No hay seleccionados");
            }

        }
        private void EliminarPacientes(List<String> PacienteEliminar)
        {
            foreach (string nombre in PacienteEliminar)
            {
                Console.WriteLine($"Paciente:  {nombre} eliminado.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
