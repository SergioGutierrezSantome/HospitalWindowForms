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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using GroupBox = System.Windows.Forms.GroupBox;

namespace HospitalFormWindowEdition
{
    public partial class FiltroPacienteMedico : Form
    {
        Hospital MiHospital;
        private GroupBox groupBoxMedicos;
        public FiltroPacienteMedico(Hospital hospital)
        {
            InitializeComponent();
            MiHospital = hospital;
            CargarMedicosPacientes();
        }

     
        private void CargarMedicosPacientes()
        {

            List<Medico> medicos = MiHospital.RepositorioMedicos.ObtenerTodos();

            groupBox1.Text = "Lista de Médicos";
            groupBox1.Location = new System.Drawing.Point(20, 20);

            int yPosition = 30; // Posición vertical inicial dentro del GroupBox

            foreach (var medico in medicos)
            {
                // Crear y configurar el Label para el nombre del médico
                groupBoxMedicos = new GroupBox();
                groupBoxMedicos.Text = "Nombre: "+medico.nombre+" Especialidad "+medico.especialidad;
                groupBoxMedicos.Location = new System.Drawing.Point(20, yPosition);
                groupBoxMedicos.Width = 100;
                groupBoxMedicos.BackColor = Color.White;
                groupBoxMedicos.Click += (sender, e) => MostrarlistaPacientes(medico.DNI);
                // Añadir los controles al GroupBox
                groupBox1.Controls.Add(groupBoxMedicos);

                // Incrementar la posición vertical para el siguiente par de controles
                yPosition += 30;
            }
        }
        private void MostrarlistaPacientes(string dni)
        {
            List<Paciente> pacientes = MiHospital.RepositorioPaciente.ObtenerTodos();
            List<PacienteFiltrado> PacienteFiltrado = new List<PacienteFiltrado>(); 
            foreach (var paciente in pacientes)
            {
                MessageBox.Show("dni igual " + paciente.asignacionmedico + " " + dni);
                if (paciente.asignacionmedico == dni)
                {
                      
                    PacienteFiltrado.Add(new PacienteFiltrado(paciente.DNI, paciente.nombre, paciente.correo, paciente.telefono, paciente.asignacionmedico));
                }
            }
            listBox1.DataSource = null;
            listBox1.DataSource = PacienteFiltrado;
            listBox1.DisplayMember = "ToString";
            MessageBox.Show(PacienteFiltrado.ToString());
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
