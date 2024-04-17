namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Snack 1
            L’utente inserisce due numeri in successione.
            Il software stampa il maggiore.
            */

            Console.WriteLine("-----INIZIO PRIMO SNACK-----");

            // chiedo il numero e lo converto in intero
            Console.WriteLine("Scrivi il primo numero che ti viene in mente");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            // chiedo il numero e lo converto in intero
            Console.WriteLine("Scrivi un secondo numero");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            if (firstNum > secondNum) // se il primo numero è maggiore 
            {
                Console.WriteLine($"Pensi subito in grande! il primo numero ({firstNum}) è il maggiore!");
            } else if (firstNum < secondNum) // se il secondo numero è maggiore
            {
                Console.WriteLine($"Pensi sempre più in grande! il secondo numero ({secondNum}) è il maggiore!");
            }
            else // se sono uguali
            {
                Console.WriteLine("Sembra proprio che il primo numero ed il secondo siano identici!");
            }

            Console.WriteLine("-----FINE PRIMO SNACK-----");
        }
               
    }
}
