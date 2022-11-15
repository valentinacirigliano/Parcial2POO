using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public class Equipo
    {
        private DirectorTecnico directorTecnico;
        public DirectorTecnico DirectorTecnico
        {
            get { return directorTecnico; }
            set { directorTecnico = value; }
        }
        private static Deporte deporte;
        public Deporte Deporte
        {
            set { deporte = value; }
            get { return deporte; }
        }
        
        private List<Jugador> listaJugadores;
        public List<Jugador> ListaJugadores
        {
            get { return listaJugadores; }
        }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        static Equipo()
        {
            deporte = Deporte.Futbol;
        }
        //este era el constructor privado donde instanciaba la lista, pero lo hice público para el json
        public Equipo()
        {
            listaJugadores = new List<Jugador>();
        }
        public Equipo(string Nombre, DirectorTecnico dt,Deporte Deeporte):this()
        {
            nombre= Nombre;
            directorTecnico = dt;
            deporte = Deeporte;
        }
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is Equipo))
            {
                return false;
            }
            return this.nombre == ((Equipo)obj).nombre &&
                this.directorTecnico == ((Equipo)obj).directorTecnico;
        }
        public static bool operator==(Equipo e, Jugador j)
        {
            bool existe=false;
            foreach (var jugador in e.listaJugadores)
            {
                existe = jugador.Equals(j);
            }
            return existe;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        public static bool operator +(Equipo e,Jugador j)
        {
            if (e != j)
            {
                if (e.existeCapitan())
                {
                    if (j.EsCapitan == false)
                    {
                        e.listaJugadores.Add(j);
                        return true;
                    }
                    return false;
                }
                e.listaJugadores.Add(j);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool existeCapitan()
        {
            foreach (var j in this.listaJugadores)
            {
                if (j.EsCapitan)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator -(Equipo e, Jugador j)
        {
            if (e == j)
            {
                e.listaJugadores.Remove(j);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static implicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"**{e.Nombre}**");
            foreach (var j in e.listaJugadores)
            {
                sb.AppendLine(j.FichaTecnica());
            }
            sb.AppendLine(e.directorTecnico.FichaTecnica());
            return sb.ToString();
        }
    }
}
