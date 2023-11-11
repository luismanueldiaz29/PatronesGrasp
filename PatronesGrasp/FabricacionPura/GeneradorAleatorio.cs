
namespace PatronesGrasp.FabricacionPura
{
    public class GeneradorAleatorio
    {
        private Random random;
        public GeneradorAleatorio()
        {
            random = new Random();
        }

        public int GenerarNumeroAleatorio()
        {
            // Lógica para generar un número aleatorio
            return random.Next();
        }
    }
}
