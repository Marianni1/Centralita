using System;

namespace CentralTelefonica
{
    class LlamadaLocal : Llamada
{
    public LlamadaLocal(string numOrigen, string numDestino, int duracion)
    {
        this.numOrigen = numOrigen;
        this.numDestino = numDestino;
        this.duracion = duracion;
        this.costo = duracion * 0.15;
    }

    public override string ToString()
    {
        return "LA LLAMADA LOCAL DE SANTO DOMINGO DEL NUMERO " + this.numOrigen + " a " + this.numDestino + " CON DURACION DE " + this.duracion + " segundos. TIENE UN COSTO DE " + this.costo + " PESOS DOMINICANOS";
    }
    
    

}
}
