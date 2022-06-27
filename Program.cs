/*
 Il software deve chiedere per 10 volte all’utente di inserire un numero.
Il programma stampa la somma di tutti i numeri inseriti.

 
*/

namespace csharp_snacks_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.Write("Inserire il numero: ");
                int userNumber = Int32.Parse(Console.ReadLine());
                sum += userNumber; 
            }

            Console.WriteLine(sum);
        }
    }
}