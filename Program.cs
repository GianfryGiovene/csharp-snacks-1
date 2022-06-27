/*
 4- Calcola la somma e la media dei numeri da 2 a 10;

 3-Il software deve chiedere per 10 volte all’utente di inserire un numero.
Il programma stampa la somma di tutti i numeri inseriti.

 
*/

namespace csharp_snacks_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            return;
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