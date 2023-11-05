using EjercicioMeses.Servicios;

namespace EjercicioMeses.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            CalculoInterfaz ci = new CalculoImplementacion();

            char tecla = 's';
            bool acceso = false;

            while (!acceso)
            {
                if (tecla == 's')
                {
                    int mes = mi.pedirMes();
                    int anyo = mi.pedirAnyo();
                    ci.hacerCalculo(mes, anyo);

                    Console.WriteLine("¿Desea hacer una nueva consulta de mes y año?");
                    tecla = Convert.ToChar(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Hasta pronto");
                    acceso = true;
                }
            }

            
        }
    }
}
