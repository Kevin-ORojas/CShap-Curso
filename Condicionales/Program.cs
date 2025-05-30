// concionales if, sirven una sentencia interna que sirve en boolean se cumple o no

// operador and && Y
// operador || OR O
namespace Condicionales
{
    class Program
    {
        static void Main(string[] args) {


            bool areYouHungri = true;
            bool youHaveMoney = true;

            if (areYouHungri && youHaveMoney && IsOpenRestaurant("Lonches pepe", 9))
            {
                Console.WriteLine("comes");
           
            } else
            {
                Console.WriteLine("no comes");
            }
        }

        static bool IsOpenRestaurant(string name, int hour = 0)
        {
            if (name == "Lonches pepe" && hour > 8 && hour < 23)
            {
                return true;
            } else if(name == "Restaurant 24 hours")
            {
                return true;
            } else
            {
                return false;

            }
        }
    }
}