List<double> listaDouble = new() { 10.5, 1.9, 3.6, 9.3, 7.8, 5.5 };

Console.WriteLine("Scegli cosa vuoi fare:\n\n 1) Skip\n 2) Take\n 3) Skip and Take\n");

var input = Console.ReadKey().KeyChar;

try
{
    switch (input)
    {
        case '1':
            Console.WriteLine("\nInserisci il numero di elementi da saltare:\n");

            var inputSkip = int.Parse(Console.ReadLine()!);

            if (inputSkip >= 0 && inputSkip < listaDouble.Count)
            {

                Console.WriteLine("\nElementi presi in evidenza:\n");


                var sottoInsiemeSkip = listaDouble.Skip(inputSkip).ToList();

                sottoInsiemeSkip.ForEach(x => Console.WriteLine(x));

                Console.WriteLine($"Risultato Numero Elmenti: {sottoInsiemeSkip.Count}\nRisultato Media: {sottoInsiemeSkip.Average()}\nRisultato Somma: {sottoInsiemeSkip.Sum()}");
            }
            else
            {
                Console.WriteLine("Il numero inserito è più grande della lunghezza della lista");

            }

            break;
        case '2':
            Console.WriteLine("\nInserisci il numero di elementi da prendere:\n");

            var inputTake = int.Parse(Console.ReadLine()!);

            if (inputTake >= 0 && inputTake < listaDouble.Count)
            {

                Console.WriteLine("\nElementi presi in evidenza:\n");

                var sottoInsiemeTake = listaDouble.Take(inputTake).ToList();

                sottoInsiemeTake.ForEach(x => Console.WriteLine(x));

                Console.WriteLine($"Risultato Numero Elmenti: {sottoInsiemeTake.Count}\nRisultato Media: {sottoInsiemeTake.Average()}\nRisultato Somma: {sottoInsiemeTake.Sum()}");

            }
            else
            {
                Console.WriteLine("Il numero inserito è più grande della lunghezza della lista");
            }
            break;

        case '3':
            Console.WriteLine("\nInserisci il numero di elementi da saltare:\n");

            var inputSkip2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("\nInserisci il numero di elementi da prendere:\n");

            var inputTake2 = int.Parse(Console.ReadLine()!);

            if (inputSkip2 >= 0 && inputSkip2 < listaDouble.Count || inputTake2 >= 0 && inputTake2 < listaDouble.Count)
            {

                Console.WriteLine("\nElementi presi in evidenza:\n");

                var sottoInsiemeSkipAndTake = listaDouble.Skip(inputSkip2).Take(inputTake2).ToList();

                sottoInsiemeSkipAndTake.ForEach(x => Console.WriteLine(x));

                Console.WriteLine($"\nRisultato Numero Elmenti: {sottoInsiemeSkipAndTake.Count}\nRisultato Media: {sottoInsiemeSkipAndTake.Average()}\nRisultato Somma: {sottoInsiemeSkipAndTake.Sum()}");
            }
            else
            {
                Console.WriteLine("Il numero inserito è più grande della lunghezza della lista");
            }
            break;

        default:
            Console.WriteLine("\nIl numero digitato non è corretto\n");
            break;
    }
}
catch (FormatException)
{
    Console.WriteLine("\nErrore Formato. Il formato inserito non è corretto\n");

}
catch (OverflowException)
{
    Console.WriteLine("\nErrore di OverFlow. Inserisci un numero più piccolo\n");
}
catch(Exception e)
{
    Console.WriteLine("\nErrore Sconosciuto\n");

}


