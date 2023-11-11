using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGrasp.VariacionProtegida
{
    public interface IProveedorPago
    {
        void ProcesarPago(double monto);
    }
}
