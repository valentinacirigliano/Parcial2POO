using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public class DirectorTecnico : Persona
    {
        private static Tipo tipo;
        static DirectorTecnico()
        {
            tipo = Tipo.Tecnico;
        }
        public DirectorTecnico(string Nombre, string Apellido) : base(Nombre, Apellido)
        {
        }

        public override string FichaTecnica()
        {
            return $"{Nombre.ToUpper()} {Apellido.ToUpper()}, director técnico";
        }
    }
}
