using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public class Jugador : Persona
    {
        private static Tipo tipo;
        private int numero;
        public int Numero
        {
            get { return numero; }
        }
        private bool esCapitan;
        public bool EsCapitan
        {
            get { return esCapitan; }
        }
        static Jugador()
        {
            tipo = Tipo.Jugador;
        }
        public Jugador(string Nombre, string Apellido):this(Nombre, Apellido,0, false)
        {

        }
        public Jugador(string Nombre, string Apellido, int Numero, bool EsCapitan) : base(Nombre, Apellido)
        {
            numero = Numero;
            esCapitan = EsCapitan;
        }

        public override string FichaTecnica()
        {
            if (esCapitan)
            {
                return $"{Apellido.ToUpper()} {Nombre}, capitán del equipo, camiseta número {Numero}";
            }
            else
            {
                return $"{Apellido.ToUpper()} {Nombre}, camiseta número {Numero}";
            }
        }
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is Jugador))
            {
                return false;
            }
            return this.Nombre==((Jugador)obj).Nombre &&
                this.Apellido ==((Jugador)obj).Apellido &&
                this.numero==((Jugador)obj).Numero;
        }
        public static bool operator ==(Jugador j, Jugador j2)
        {
            return j.Equals(j2);
        }
        public static bool operator !=(Jugador j, Jugador j2)
        {
            return !(j==j2);
        }
        public static explicit operator int(Jugador j)
        {
            return j.numero;
        }
    }
}
