using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGrasp.VariacionProtegida
{
    public class ServicioPago
    {
        private IProveedorPago proveedorPago;

        public ServicioPago(IProveedorPago proveedorPago)
        {
            this.proveedorPago = proveedorPago;
        }

        public void RealizarPago(double monto)
        {
            // Lógica general de procesamiento de pago
            Console.WriteLine($"Iniciando proceso de pago...");

            // Utiliza el proveedor de pago específico (variación protegida)
            proveedorPago.ProcesarPago(monto);

            // Lógica posterior al pago
            Console.WriteLine($"Proceso de pago completado.");
        }
    }
}
