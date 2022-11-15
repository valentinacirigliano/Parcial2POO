using Parcial2POO.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Datos
{
    public static class ManejadorArchivoSecuencial
    {
        private static string archivo = "Personas.txt";
        private static string archivo2 = "PersonasTexto.txt";
        private static string archivo3 = "PersonasArray.txt";

        public static void GuardarTextArray(List<Persona> lista)
        {
            var arrayLineas = ConstruirArrayLineas(lista);
            File.WriteAllLines(archivo3, arrayLineas);
        }

        private static string[] ConstruirArrayLineas(List<Persona> lista)
        {
            List<string> listaStrings = new List<string>();
            foreach (var persona in lista)
            {
                listaStrings.Add(ConstruirLinea(persona));
            }

            return listaStrings.ToArray();
        }

        public static void GuardarTodoTexto(List<Persona> lista)
        {
            var textoAlumnos = ConstruirTexto(lista);
            File.WriteAllText(archivo2, textoAlumnos);
        }

        private static string ConstruirTexto(List<Persona> lista)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var persona in lista)
            {
                sb.AppendLine(ConstruirLinea(persona));
            }

            return sb.ToString();
        }

        public static void Guardar(Persona persona)
        {
            using (var escritor = new StreamWriter(archivo, true))
            {
                var linea = ConstruirLinea(persona);
                escritor.WriteLine(linea);
            }
        }

        private static string ConstruirLinea(Persona persona)
        {
            //TODO:Cambiar datos
            return $"{alumno.Legajo}|{alumno.Nombre}|{alumno.Apellido}";
        }

        public static List<Persona> LeerDatos()
        {
            List<Persona> lista = new List<Persona>();
            if (!File.Exists(archivo))
            {
                return lista;
            }

            using (var lector = new StreamReader(archivo))
            {
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    Persona p = ConstruirPersona(linea);
                    lista.Add(p);
                }
            }

            return lista;
        }


        //tenemos jugador o director tecnico, son  personas
        //personas no se puede instanciar
        private static Persona ConstruirPersona(string linea)
        {
            var campos = linea.Split('|');
            //TODO:cambiar persona-alumno
            Persona persona = new Persona()
            {
                Nombre = campos[0],
                Apellido = campos[1]
            };
            return persona;
        }
    }
}
