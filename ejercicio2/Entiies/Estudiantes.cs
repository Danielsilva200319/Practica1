using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio2.Entiies
{
    public class Estudiantes
    {
        private int id;
        private string nombre;
        public int Id
        {
            get { return Id; }
            set { id = value; }
        }
        public string Nombre
        {         
            get { return nombre; }
            set { nombre = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
    }
}