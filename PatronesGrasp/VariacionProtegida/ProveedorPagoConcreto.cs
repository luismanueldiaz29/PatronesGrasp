using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGrasp.VariacionProtegida
{
    public class ProveedorPagoConcreto : IProveedorPago
    {
        public void ProcesarPago(double monto)
        {
            // Lógica específica de procesamiento de pago
            Console.WriteLine($"Pago de {monto} procesado con ProveedorPagoConcreto");
        }
    }
}
