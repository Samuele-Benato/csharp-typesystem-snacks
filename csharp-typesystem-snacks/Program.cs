using System;

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

            Console.WriteLine($"La sum3 dei numeri inseriti è: {sum}");

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

            Console.WriteLine($"La sum3 è: {sum2} e la media è {roundedAverage}");

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

            /*
            Snack 6
            In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. 
            Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
            */

            Console.WriteLine("-----INIZIO SESTO SNACK-----");

            // inizializzo e definisco l'array degli invitati
            string[] invited = new string[5] { "alice", "bob", "charlie", "diana", "eve" };

            //chiedo all'utente il proprio nome
            Console.WriteLine("Buonasera, prego il suo nome?");
            //recupero il suo nome
            string name = Console.ReadLine().ToLower();

            // Setto di base l'invito a false
            bool isInvited = false;

            // Confronto il nome inserito dall'utente con quelli presenti nell'array degli invitati
            foreach (string invitedName in invited)
            {
                if (invitedName == name)
                {
                    isInvited = true;
                    break; // Possiamo uscire dal ciclo una volta trovato il nome corrispondente
                }
            }

            // Verifico se l'utente è stato invitato o meno
            if (isInvited)
            {
                Console.WriteLine("Sei stato invitato alla festa del Grande Gatsby!");
                Console.WriteLine("Oppure sei un omonimo, entra prima che cambi idea");
            }
            else
            {
                Console.WriteLine("Mi dispiace, non sei stato invitato alla festa del Grande Gatsby.");
            }

            Console.WriteLine("-----FINE SESTO SNACK-----");

            /*
            Snack 7
            Crea un array vuoto.
            Chiedi per 6 volte all’utente di inserire un numero,
            se è dispari inseriscilo nell’array.            
            */

            Console.WriteLine("-----INIZIO SETTIMO SNACK-----");

            int[] numbers = new int[6];

            for (int i = 0; i < 6; i++)
            {
                // chiedo il numero e lo converto in intero
                Console.WriteLine("Scrivi un numero (x6)");
                //al momento dell'inserimento lo converto in intero
                int input2 = Convert.ToInt32(Console.ReadLine());

                if (input2 % 2 == 0)
                {
                    Console.WriteLine($"Nah {input2} lo scarto");
                }
                if(input2 % 2 != 0)
                {
                    Console.WriteLine($"Bello {input2} lo lo tengo");
                    numbers[i] = input2;
                    i++;
                }
            }

            // Stampiamo i numeri inseriti nell'array
            Console.WriteLine("Tra i numeri che mi hai dato mi piacevano:");
            foreach (int input2 in numbers)
            {
                Console.WriteLine(input2);
            }

            Console.WriteLine("-----FINE SETTIMO SNACK-----");


            /*
            Snack 8
            Crea un array di numeri interi e fai la somma di tutti gli elementi
            che sono in posizione dispari.           
            */

            Console.WriteLine("-----INIZIO OTTAVO SNACK-----");

            int[] numbers2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int addEvenNumbers = 0;

            for (int i = 0; i < numbers2.Length; i++)
            {
                if (i % 2 != 0) // Controllo se l'indice è dispari
                {
                    addEvenNumbers += numbers2[i];
                }
            }

            Console.WriteLine($"La sum3 degli elementi in posizione dispari è: {addEvenNumbers}");

            Console.WriteLine("-----FINE OTTAVO SNACK-----");

            /*
            Snack 9
            Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
            Continua a chiedere i numeri all’utente e a inserirli nell’array, 
            fino a quando la somma degli elementi è minore di 50.
            */

            Console.WriteLine("-----INIZIO NONO SNACK-----");

            int[] numeri = new int[10]; // Array vuoto massimo 10 elementi

            int sum3 = 0;
            int index = 0;

            while (sum3 < 50 && index < 10)
            {
                Console.WriteLine("Inserisci un numero:");
                int num3 = Convert.ToInt32(Console.ReadLine());

                if(num3 >= 50)
                {
                    Console.WriteLine("gioco finito subito :(");
                }

                numeri[index] = num3; // Inserisci il numero nell'array
                sum3 += num3; // Aggiorna la somma degli elementi

                index++; // Passa all'elemento successivo nell'array
            }

            Console.WriteLine("La somma degli elementi dell'array è: " + sum3);
            Console.WriteLine("Gli elementi dell'array sono:");

            // Stampa gli elementi dell'array 
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(numeri[i]);
            }

            Console.WriteLine("-----FINE NONO SNACK-----");

            /*
           Snack 10
           Fai inserire un numero, che chiameremo N, all’utente.
           Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
           Ogni volta che ne crei uno, stampalo a schermo.
           */

            Console.WriteLine("-----INIZIO DECIMO SNACK-----");

            Console.WriteLine("Inserisci un numero di array:");
            int N = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                int[] array = new int[10];

                // Riempie l'array con numeri casuali compresi tra 1 e 100
                for (int j = 0; j < array.Length; j++)
                {
                    array[j] = random.Next(1, 101);
                }

                // Stampa l'array
                Console.WriteLine($"Array {i + 1}:");
                foreach (int num4 in array)
                {
                    Console.Write(num4 + " ");
                }
                Console.WriteLine(); // Stampa una nuova riga per formattazione
            }

            Console.WriteLine("-----FINE DECIMO SNACK-----");

        }

    }
}
