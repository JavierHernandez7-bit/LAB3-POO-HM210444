using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoSalario
{
    public class Salario //publica para que pueda ser usada en cualquier instancia del proyecto
    {
        private int diasLaborados; //atributo
        public int DiasLaborados //propiedad del atributo
        { get; set; }
        //método para calcular salario
        public decimal CalcularSalario(int diaslab, decimal valordia)
        {
            decimal totalsalario = diaslab * valordia;
            return totalsalario;
        }
    }
}
    
