using System;

namespace CentralTelefonica
{
    class Centralita
    {
        private int numLlamadas = 0;
        private double facturacionTotal = 0.0;

        public void registrarLlamada(Llamada llamada)
        {
            Console.WriteLine(llamada.ToString());
            this.numLlamadas++;
            this.facturacionTotal += llamada.costo;
        }

        public void informe()
        {
            Console.WriteLine("EL NUMERO TOTAL DE LLAMADAS FUE " + this.numLlamadas);
            Console.WriteLine("PARA UN TOTAL DE FACTURACION " + this.facturacionTotal + " PESOS DOMINICANOS");
        }
    }
}
