using Parcial2POO.Datos;
using Parcial2POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectorTecnico dt1 = new DirectorTecnico("Pepe", "Guardiola");
            Equipo e1 = new Equipo("Los coyotes", dt1, Deporte.Futbol);
            Jugador j1 = new Jugador("Juan", "Perez", 8, false);
            Jugador j2 = new Jugador("Titi", "Suarez", 6, false);
            Jugador j3 = new Jugador("Quique", "Lopez", 6, false);
            Jugador j4 = new Jugador("Alva", "Rito", 6, false);
            Agregar(e1, j1);
            Agregar(e1, j2);
            Agregar(e1, j3);
            Agregar(e1, j4);
            string descripcionEquipo = e1;
            Console.WriteLine(descripcionEquipo);
            Console.WriteLine($"Hay capitan:{e1.existeCapitan()}");
            Jugador j5 = new Jugador("Mano", "Lito", 6, true);

            Agregar(e1, j5);
            Agregar(e1, j5);
            Console.WriteLine($"Hay capitan:{e1.existeCapitan()}");
            Jugador j6 = new Jugador("Mano", "Lito", 6, false);
            Agregar(e1, j6);

            string NuevaDescripcionEquipo = e1;
            Console.WriteLine(NuevaDescripcionEquipo);
            List<Persona> lista = new List<Persona>();
            foreach (var j in e1.ListaJugadores)
            {
                lista.Add(j);
            }
            lista.Add(e1.DirectorTecnico);
            Serializador<List<Persona>>.GuardarJson("personas.json", lista);
            Serializador<Equipo>.GuardarJson("equipo.json", e1);
            List<Equipo> listaEquipos = new List<Equipo>();
            listaEquipos.Add(e1);
            //Serializador<List<Equipo>>.GuardarJson("equipos.json", listaEquipos);
            //Console.Clear();
            //Console.ReadLine();
            Console.WriteLine("Mostrando desde el archivo json");
            List<Equipo> listaEquiposJson=new List<Equipo>();
            listaEquiposJson = Serializador<List<Equipo>>.LeerJson("equipos.json");
            //escribe porque tiene todos los datos el json, ver la lista
            foreach (var e in listaEquiposJson)
            {
                string descripcion = e;
                Console.WriteLine(descripcion);
            }
            Console.ReadLine();

        }

        private static void Agregar(Equipo e, Jugador j)
        {
            if(e + j)
            {
                Console.WriteLine($"Se agregó a la lista {j.NombreCompleto()}");
            }
            else
            {
                Console.WriteLine("No se pudo agregar");
            }
        }
    }
}
