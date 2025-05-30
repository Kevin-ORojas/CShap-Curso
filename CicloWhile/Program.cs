using System;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i  = 0;

            while (i < 10) 
            {
                Console.WriteLine("Iteracion de i " + i);
                i++;
            }

            int j = 0;

            while(j < 100)
            {
                if (j > 10)
                    break;

                Console.WriteLine("Iteracion de j" + j);
                j++;
            }


        string[] friends = [
            "Kevin",
            "pedro",
            "arnaldo",
            "pantalon",
            "camisa"
            ];


        int index = 0;
        while(index < friends.Length)
            {
                Console.WriteLine(friends[index]);
                index++;
            }
        }
    }
}