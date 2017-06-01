using ConsoleApplication5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            var miClase = new Clase();
            
        }
        private IList<Alumno> CargarAlumnos()
        {
            var lista = new List<Alumno>();
            lista.Add(new Alumno("Yusep", "Guardiola", 3, "ER20983"));
        }
    }
}
