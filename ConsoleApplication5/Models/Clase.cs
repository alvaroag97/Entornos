using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5.Models
{
    class Clase
    {

        public Profesor profe;
        public IList<Alumno> Alumnos;

        public Clase()
        {

           Alumnos = new List<Alumno>();

        }

        static public float CalcularMedia()
        {
            return GetAlumnos().
        }

        public void EvaluarTodos()
        {
            Console.WriteLine("-EVALUANDO-");
        }
    }
}
