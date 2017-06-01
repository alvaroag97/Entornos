using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5.Models
{
    class Persona : Interfaces.Saludable
    {
        private String Nombre;
        private String Apellido;
        private int Edad;

      

        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = -1;
        }
        public string getNombre
        {
            get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
            }
        }

        public string GetApellido
        {
            get
            {
                return Apellido;
            }

            set
            {
                Apellido = value;
            }
        }

        public int GetEdad
        {
            get
            {
                return Edad;
            }

            set
            {
                if(Edad < 0)
                {
                    throw new Exception("Introduzca edad valida");
                }else
                {
                    Edad = value;
                }
            }
        }

        public void Saludar(string Hola)
        {
            
        }
    }
}
