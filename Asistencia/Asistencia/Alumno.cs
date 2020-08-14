using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistencia
{
    class Alumno
    {
        private int Codigo;
        private int Legajo;
        private String Nombre;
        private String Apellido;
        private int Curso;
        private Boolean Presente;

        public int pCodigo { get => Codigo; set => Codigo = value; }
        public int pLegajo { get => Legajo; set => Legajo = value; }
        public string pNombre { get => Nombre; set => Nombre = value; }
        public string pApellido { get => Apellido; set => Apellido = value; }
        public int pCurso { get => Curso; set => Curso = value; }
        public bool pPresente { get => Presente; set => Presente = value; }

        public override string ToString()
        {
            return " Legajo : " + pLegajo + " / " + NombreCurso() + " / " + pApellido + " " + pNombre;
        }
        public String NombreCurso()
        {
            String Nombre = " ";
            if (pCurso == 1)
            {
                Nombre = "2W50";
            }
            else
            {
                Nombre = "2W2";
            }
            return Nombre;
        }
    }
}
