using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public abstract class Persona
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
        }
        private string apellido;
        public string Apellido
        {
            get { return apellido; }
        }
        public Persona(string Nombre, string Apellido)
        {
            nombre = Nombre;
            apellido = Apellido;
        }
        public abstract string FichaTecnica();
        public virtual string NombreCompleto()
        {
            return $"{nombre} {apellido}";
        }
    }
}
