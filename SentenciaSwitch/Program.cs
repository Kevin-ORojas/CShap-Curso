using System;

namespace SentenciaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 6;


            switch(op)
            {
                case 1:
                    op = 2;
                    Console.WriteLine(op);
                    break;
                    case 2:
                    op = 3;
                    Console.WriteLine(op);
                    break;
                    case 3:
                    op = 4;
                    Console.WriteLine(op);
                    break;
                    case 4:
                    op = 5;
                    Console.WriteLine(op);
                    break;
                    default:
                    Console.WriteLine("Invalido");
                    break;
            }
        
        
        }
    }
}