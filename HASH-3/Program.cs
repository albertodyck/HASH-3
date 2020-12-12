using System;

namespace HASH_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MiHash datos = new MiHash();

            ListaLigada Antonio = new ListaLigada("uno", "Antonio");

            ListaLigada Jose = new ListaLigada("dos", "Jose");

            ListaLigada Alberto = new ListaLigada("tres", "Alberto");

            ListaLigada Julieth = new ListaLigada("cuatro", "Julieth");

            ListaLigada Gaby = new ListaLigada("cinco", "Gaby");

            datos.add(Antonio);

            datos.add(Jose);

            datos.add(Alberto);

            datos.add(Julieth);

            datos.add(Gaby);

            Console.ReadKey();

        }
    }
}
