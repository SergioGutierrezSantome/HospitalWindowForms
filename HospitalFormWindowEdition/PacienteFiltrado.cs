using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class PacienteFiltrado : Persona
    {
        public PacienteFiltrado(string dNI, string nombre, string correo, string telefono, string asignacionmedico) : base(dNI, nombre, correo, telefono)
        {

        }
        public override void MostrarInfo()
        {
            Console.WriteLine($"[Paciente] {ToString()}");
        }
     
        public override string ToString()
        {
            return $"DNI:{DNI} Nombre: {nombre} Correo: {correo}  Telefono: {telefono}";
        }
    }
}
