using Hospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFormWindowEdition
{

    public class Hospital
    {
       public  Repositorio<Administrativo> repositorioAdmin = new Repositorio<Administrativo>();
         Repositorio<Medico> repositorioMedicos = new Repositorio<Medico>();
         Repositorio<Paciente> repositorioPaciente = new Repositorio<Paciente>();
         Repositorio<Persona> repositorioPersona = new Repositorio<Persona>();

        public Hospital()
        {
        }

        public Repositorio<Administrativo> RepositorioAdmin { get => repositorioAdmin; set => repositorioAdmin = value; }
        public Repositorio<Paciente> RepositorioPaciente { get => repositorioPaciente; set => repositorioPaciente = value; }
        public Repositorio<Persona> RepositorioPersona { get => repositorioPersona; set => repositorioPersona = value; }
        public Repositorio<Medico> RepositorioMedicos { get => repositorioMedicos; set => repositorioMedicos = value; }

        public override bool Equals(object obj)
        {
            return obj is Hospital hospital &&
                   EqualityComparer<Repositorio<Medico>>.Default.Equals(RepositorioMedicos, hospital.RepositorioMedicos);
        }
    }
}
