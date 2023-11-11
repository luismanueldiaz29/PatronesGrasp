using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGrasp.Polimorfismo
{
    public class GestorDibujo
    {
        public void DibujarFigura(Figura figura)
        {
            // Lógica para dibujar la figura, redirigiendo a la implementación específica
            figura.Dibujar();
        }
    }
}
