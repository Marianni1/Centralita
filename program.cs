using System;

namespace CentralTelefonica
{
    class Program
{
    static void Main(string[] args)
    {
        Centralita centralita = new Centralita();

        LlamadaLocal llamadaLocal = new LlamadaLocal("829-888-8899", "829-333-7788", 20);
        centralita.registrarLlamada(llamadaLocal);

        LlamadaLocal llamadaLocal2 = new LlamadaLocal("829-888-8899", "809-888-7744", 20);
        centralita.registrarLlamada(llamadaLocal);

        LlamadaProvincial llamadaProvincial1 = new LlamadaProvincial("839-44-4477", "839-555-4455", 40, 2);
        centralita.registrarLlamada(llamadaProvincial1);

        LlamadaProvincial llamadaProvincial2 = new LlamadaProvincial("899-666-9988", "899-555-7788", 40, 3);
        centralita.registrarLlamada(llamadaProvincial2);

        centralita.informe();

        var fechaH = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine} FECHA Y HORA DE LA LLAMADA {fechaH:d} a las {fechaH:t}");
        Console.Write($"{Environment.NewLine}");


        Console.ReadKey(true);
    }
}

}