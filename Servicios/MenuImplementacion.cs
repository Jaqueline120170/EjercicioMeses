using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMeses.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int pedirMes()
        {
            Console.WriteLine("Introduzca el número de mes");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero de mes introducido es :" + mes);
            return mes;
        }

        public int pedirAnyo()
        {
            Console.WriteLine("Introduzca un anyo");
            int anyo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El anyo introducidoes :" +  anyo);
            return anyo;
        }
    }
    
   
}
