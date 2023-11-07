using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMeses.Servicios
{
    internal interface CalculoInterfaz
    {
        public void hacerCalculo(int mes, int anyo);
        /// <summary>
        /// Método que solicita al usuario dos enteros identificados como mes y anyo para hacer el calculo de 
        /// si se trata de un año bisiesto o no y con ello hacer el calculo de los días que tendrá el mes introducido.
        /// 07112023 - jrt
        /// </summary>
    }
}
