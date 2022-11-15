using Parcial2POO.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Datos
{
    public class ManejadorAS
    {
        //private static string archivo = "Equipos.txt";

        //private static string ConstruirLinea(Equipo equipo)
        //{
        //    return $"{equipo.Nombre}|{equipo.Deporte}|{equipo.DirectorTecnico.FichaTecnica()}";
        //}
        //private static Equipo ConstruirEquipo(string linea)
        //{
        //    var campos = linea.Split('|');
        //    Equipo equipo = new Equipo()
        //    {
                

        //    };
        //    return equipo;
        //}
        //public static List<Equipo> LeerDatos()
        //{
        //    List<Equipo> lista = new List<Equipo>();
        //    if (!File.Exists(archivo))
        //    {
        //        return lista;
        //    }

        //    using (var lector = new StreamReader(archivo))
        //    {
        //        while (!lector.EndOfStream)
        //        {
        //            var linea = lector.ReadLine();
        //            Equipo e = ConstruirEquipo(linea);
        //            lista.Add(e);
        //        }
        //    }

        //    return lista;
        //}
    }
}
