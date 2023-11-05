using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EjercicioMeses.Servicios
{
    internal class CalculoImplementacion : CalculoInterfaz
    {
        public void hacerCalculo(int mes, int anyo)
        {
            if ((anyo % 4 == 0) && (anyo % 100 != 0) || anyo % 400 == 0)
            {
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12){
                    Console.WriteLine("El mes introducido tiene 31 días");
                }
               else if (mes == 4 || mes ==6 || mes==9|| mes ==11){
                    Console.WriteLine("El mes introducido tiene 30 días");
                }
                else
                {
                    Console.WriteLine("El mes introducido tiene 29 días");
                }
            }
            else {
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    Console.WriteLine("El mes introducido tiene 31 días");
                }
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    Console.WriteLine("El mes introducido tiene 30 días");
                }
                else
                {
                    Console.WriteLine("El mes introducido tiene 28 días");
                }
            }
        }
    }
}
