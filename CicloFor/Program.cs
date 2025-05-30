// Ciclo For
using System;

namespace CicloFor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = ["pantalon", "caminsa", "chaqueta", "ahorros", "gastos"];


            for(int i = 0; i <friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }

        }
    }
}

