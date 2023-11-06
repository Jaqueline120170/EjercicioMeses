using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMeses.Servicios
{
    /// <summary>
    /// Interfaz con la relación de metodos y la funcionalidad del menu
    /// 06112023 - jrt
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que mostrará el mensaje para recoger el mes y año que seleccione el usuario
        /// 06112023 - jrt
        /// </summary>
        /// <returns> en este caso será un entero que muestre la opción que ha seleccionado</returns>
        public int pedirMes();

        public int pedirAnyo();
    }

}
