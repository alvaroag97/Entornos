using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5.Models
{
    class Profesor
    {
        private float Sueldo;

        public Profesor(float sueldo)
        {
            Sueldo = sueldo;
        }

        public float Sueldo1
        {
            get
            {
                return Sueldo;
            }

            set
            {
                Sueldo = value;
            }
        }

        public void Regañar(String regañar)
        {

        }
    }
}
