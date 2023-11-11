using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGrasp.BajoAcoplamiento
{
    public class ProcesadorDeDatos
    {
        private Logger logger;

        public ProcesadorDeDatos(Logger logger)
        {
            this.logger = logger;
        }

        public void Procesar(string datos)
        {
            // Lógica para procesar datos
            logger.Registrar("Datos procesados con éxito");
        }
    }
}
