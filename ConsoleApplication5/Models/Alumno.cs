using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5.Models
{
    class Alumno
    {
        private String Matricula;
        private float Nota;

        public Alumno(string matricula, string nota)
        {
            Matricula = matricula;
            Nota = nota;
        }

        public string Matricula1
        {
            get
            {
                return Matricula;
            }

            set
            {
                Matricula = value;
            }
        }

        public float Nota1
        {
            get
            {
                return Nota;
            }

            set
            {
                if (value < 0 || value > 10)
                {
                    throw new Exception("No has introducido una nota valida");
                    Nota = value;
                }
                    
                
            }
        }

            public void Quejarse(String quejarse)
        {

        }

        }
    }
}
