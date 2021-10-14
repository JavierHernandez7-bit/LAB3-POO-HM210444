using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Ejercicio_2
{
    class Registro
    {
        string carnet, nombres, apellidos, materia, asignatura;
        double nota1, nota2, nota3;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Carnet
        {
            get { return carnet; }
            set { carnet = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        public string Asignaturas
        {
            get { return asignatura; }
            set { asignatura = value; }
        }

        public double Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        public double Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public double Nota3
        {
            get { return nota3; }
            set { nota3 = value; }
        }

    }
}
