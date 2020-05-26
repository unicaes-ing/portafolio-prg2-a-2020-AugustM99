using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_9
{
    public class Mascota
    {
        private string nombre;
        private string tipo;
        private string sexo;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
