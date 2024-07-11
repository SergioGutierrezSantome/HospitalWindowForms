using Hospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalFormWindowEdition
{
    internal static class Program
    {
        static Repositorio<Administrativo> repositorioAdmin = new Repositorio<Administrativo>();
        static Repositorio<Medico> repositorioMedicos = new Repositorio<Medico>();
        static Repositorio<Paciente> repositorioPaciente = new Repositorio<Paciente>();
        static Repositorio<Persona> repositorioPersona = new Repositorio<Persona>();
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppPrincipal());
        }
    }
}
