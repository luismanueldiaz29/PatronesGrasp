using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGrasp.Experto
{
    public class Usuario
    {
        public DateTime FechaNacimiento { get; set; }
        public int CalcularEdad()
        {
            // Lógica para calcular la edad utilizando la fecha de nacimiento
            return DateTime.Now.Year - FechaNacimiento.Year;
        }
    }

}
