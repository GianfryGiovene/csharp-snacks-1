/*
 10- Fai inserire un numero, che chiamaremo N, all'utente. Genera N arry, ognunoi formato da 10 numeri casuali tra 1 e 100.

 5- Il software chiede all'utente di inserire il numero. Se il numero inserito è pari, stampa il numero, se è dispari stampa il numero successivo
 4- Calcola la somma e la media dei numeri da 2 a 10;

 3- Il software deve chiedere per 10 volte all’utente di inserire un numero.
    Il programma stampa la somma di tutti i numeri inseriti.

 
*/

namespace csharp_snacks_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //snack 10
            Random rnd = new Random();
            Console.Write("Inserire un numero: ");
            int arrays = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < arrays; i++)
            {
                int[] randomNumberArray = new int[10];
                    for (int k = 0; k < 10; k++)
                    {
                        randomNumberArray[k] = rnd.Next(1,100);
                        Console.Write(randomNumberArray[k]);
                        if(k < 10-1)
                        {
                            Console.Write(",");
                        }
                    }
                    Console.Write("\n");
            }
            return;

            //snack 5
            Console.Write("Inserire un numero: ");
            int newUserNumber = Int32.Parse(Console.ReadLine());

            if (newUserNumber % 2 != 0)
            {
                Console.WriteLine(newUserNumber +1 );
            }
            else
            {
                Console.WriteLine(newUserNumber);  
            }

            
            
            //snack 4
            int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int numbersSum = 0;
            float average;

            for(int i = 0; i < numbers.Length; i++)
            {
                numbersSum += numbers[i];
            }

            average = numbersSum / numbers.Length;

            Console.WriteLine($"La somma dei numeri è: {numbersSum}. La media dei numeri è: {average}");
            


            //snack 3
            int sum = 0;

            for(int i = 0; i < 10; i++)
            {
                int userNumber;
                Console.Write($"Inserire il {i + 1}° numero: ");
                userNumber = Int32.Parse(Console.ReadLine());
                sum += userNumber; 
            }

            Console.WriteLine(sum);
        }
    }
}