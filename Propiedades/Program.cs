using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale mySale = new Sale(100, DateTime.Now);
            mySale.Total = 15000;
            Console.WriteLine(mySale.Total);
        }

        class Sale
        {
            private int total;
            DateTime date;

            // esto es una propiedad
            public int Total
            {
                get // get nos permite obtener
                {
                    return total;
                }
                set //esto nos permite editar
                {
                    if (value < 0);
                        value = 0;
                    total = value;
                }
            }
            //=============================//
            public Sale(int total, DateTime time)
            {
                //esto es un un constructor por que se llama igual a la clase
                this.total = total;
                this.date = time;
            }

        }
    }
}