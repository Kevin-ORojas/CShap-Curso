// Funciones es empaquetar para poder reutilizar esa funcionalidad.

static void Show()
{
    Console.WriteLine("Hola soy un text dentro de una funcion");

    Sum(4, 8);
}

Show();


static void Sum(int num1, int num2)
{
    int number3 = num1 + num2;
    Console.WriteLine(number3);

    int m = Mul(2, 4);
    Console.WriteLine(m);
}



static int Mul(int num1, int num2)
{
   return num1 * num2;
}