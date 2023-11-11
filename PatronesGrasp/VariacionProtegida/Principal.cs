using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGrasp.VariacionProtegida
{
    public class Principal
    {
        static void Ejecutar()
        {
            IProveedorPago proveedorPagoConcreto = new ProveedorPagoConcreto();
            ServicioPago servicioPagoConcreto = new ServicioPago(proveedorPagoConcreto);
            servicioPagoConcreto.RealizarPago(50.0);
        }

    }
}
