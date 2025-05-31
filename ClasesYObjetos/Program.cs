using System;
using System.Security.Cryptography.X509Certificates;

namespace ClasesYObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale1 = new Sale(100, DateTime.Now);
            Sale sale2 = new Sale(200, DateTime.Now);
            Console.WriteLine(sale1.GetInfo());
            Console.WriteLine(sale2.GetInfo());
        }

    }

    class Sale
    {
        int total;
        DateTime date;

        public Sale(int total, DateTime time)
        {
            //esto es un un constructor por que se llama igual a la clase
            this.total = total;
            this.date = time;
        }

        public string GetInfo()
        {
            return total + " " + date.ToLongDateString();
        }
        public void Show()
        {
            Console.WriteLine("Hola soy una ventana");
        }
    }
}