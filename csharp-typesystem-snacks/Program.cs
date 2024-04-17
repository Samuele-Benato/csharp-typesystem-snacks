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

            /* 
            Snack 2
            L’utente inserisce due parole in successione.
            Il software stampa prima la parola più corta, poi la parola più lunga.
            */

            Console.WriteLine("-----INIZIO SECONDO SNACK-----");

            // chiedo la prima parola
            Console.WriteLine("Scrivi la parola che ti ricorda le vacanze");
            string firstWord = Console.ReadLine();
            
            // chiedo la seconda parola
            Console.WriteLine("Scrivi la parola che ti ricorda il lavoro");
            string secondWord = Console.ReadLine();


            if (firstWord.Length > secondWord.Length) // se la prima parola è più lunga
            {
                Console.WriteLine($"La parola più lunga è {firstWord} con ben {firstWord.Length} caratteri, mi sa che è ora di una pausa!");
                Console.WriteLine($"Invece {secondWord} con {secondWord.Length} caratteri è la più corta");
            }else if(firstWord.Length < secondWord.Length) // se la seconda parola è più lunga
            {
                Console.WriteLine($"La parola più lunga è {secondWord} con {secondWord.Length} caratteri, basta pensare al lavoro!");
                Console.WriteLine($"Invece {firstWord} con {firstWord.Length} caratteri è la più corta");
            }
            else // se le parole sono lunghe uguali
            {
                Console.WriteLine($"Le due parole hanno la stessa lunghezza ovvero {secondWord.Length} caratteri");
            }

            Console.WriteLine("-----FINE SECONDO SNACK-----");

            /*
            Snack 3
            Il software deve chiedere per 10 volte all’utente di inserire un numero.
            Il programma stampa la somma di tutti i numeri inseriti.
            */

            Console.WriteLine("-----INIZIO TERZO SNACK-----");

            // inizializzo la somma a 0
            int sum = 0;

            // per 10 volte chiedo il numero 
            for(int i = 0; i < 10; i++)
            {
                // chiedo il numero e lo converto in intero
                Console.WriteLine("Scrivi un numero (x10)");
                //al momento dell'inserimento lo converto in intero
                int input = Convert.ToInt32(Console.ReadLine());
                //sommo tutti i numeri
                sum += input;
            }

            Console.WriteLine($"La somma dei numeri inseriti è: {sum}");

            Console.WriteLine("-----FINE TERZO SNACK-----");

            /*
            Snack 4
            Calcola la somma e la media dei numeri da 2 a 10.
            */

            Console.WriteLine("-----INIZIO QUARTO SNACK-----");

            // inizializzo la somma a 0
            int sum2 = 0;

            // per 10 volte chiedo il numero 
            for (int i = 2; i < 10; i++)
            {
                sum2 += i;
            }

            // Calcolo della media
            double average = sum2 / 9;
            double roundedAverage = Math.Round(average, 1);

            Console.WriteLine($"La somma è: {sum2} e la media è {roundedAverage}");

            Console.WriteLine("-----FINE QUARTO SNACK-----");

            /*
            Snack 5
            Il software chiede all’utente di inserire un numero. 
            Se il numero inserito è pari, stampa il numero,
            se è dispari, stampa il numero successivo.
            */

            Console.WriteLine("-----INIZIO QUINTO SNACK-----");

            // chiedo il numero e lo converto in intero
            Console.WriteLine("Odio i numeri dispari, inserisci un numero");
            //al momento dell'inserimento lo converto in intero
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"Ben fatto {num} mi piace come numero");
            }
            else
            {
                Console.WriteLine($"{num + 1} mi piace di più");
            }

            Console.WriteLine("-----FINE QUINTO SNACK-----");
        }
               
    }
}
