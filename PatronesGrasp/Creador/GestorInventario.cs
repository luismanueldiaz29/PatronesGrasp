using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGrasp.Creador
{
    public class GestorInventario
    {
        public Producto CrearProducto(string nombre, decimal precio, int stock)
        {
            // Lógica para crear un nuevo producto con la información proporcionada
            return new Producto(nombre, precio, stock);
        }
    }
}
