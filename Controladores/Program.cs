using EjercicioMeses.Servicios;

namespace EjercicioMeses.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 06112023 - jrt
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada de la aplicación
        /// 06112023 - jrt
        /// </summary>
        /// <param name="args"></param>
        
        static void Main(string[] args)
        {
            /// Método Main, nos indica la logica, es el más importante.
            /// 06112023 - jrt 
           
            MenuInterfaz mi = new MenuImplementacion();
            CalculoInterfaz ci = new CalculoImplementacion();

            char tecla = 's';
            bool acceso = false;
            // variable que controla la entrada y salida del bucle while
            while (!acceso)
            // se ejecuta el buble hasta que la opción acceso sea igual a 'true' 
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
