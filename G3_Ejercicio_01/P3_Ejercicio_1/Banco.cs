using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Ejercicio_1
{
    class Banco
    {
        // Atributos
        string nombres, apellidos, dui, nit, sucursal, tipoCuenta, numeroCuenta;
        double monto;

        // Propiedades
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Dui
        {
            get { return dui; }
            set { dui = value; }
        }

        public string Nit
        {
            get { return nit; }
            set { nit = value; }
        }

        public string Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }

        public string TipoCuenta
        {
            get { return tipoCuenta; }
            set { tipoCuenta = value; }
        }

        public string NumeroCuenta
        {
            get { return numeroCuenta; }
            set { numeroCuenta = value; }
        }

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }
    }
}
