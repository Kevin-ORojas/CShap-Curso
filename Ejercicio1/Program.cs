/*
 
Problema: Gestión de Calificaciones
Crea un programa en C# que permita almacenar las calificaciones de 5 estudiantes en un arreglo. Luego, el programa debe calcular y mostrar:
- El promedio de las calificaciones.
- La calificación más alta.
- La calificación más baja.



 */

class Program
{

static void Main()
{
    int Calificaciones = 74;
    string Aprobado = "Aprobado";
    string Reprobado = "Reprobado";

    //recorrer el array y evaluar cada calificacion si tengo una lista de notas esto las recorre y me indica cuales estan aprobados o reprobadas.
    //foreach (int calificacion in calificaciones)
    //{
    //    Cal(calificacion, Aprobado, Reprobado);
        
    //}

        Cal(Calificaciones,Aprobado, Reprobado);
}


static void Cal(int Calificaciones, string Aprobado, string Reprobado)
{
    if (Calificaciones >= 75 && Calificaciones <= 100)
    {
        Console.WriteLine(Aprobado);
    }
    else if (Calificaciones <= 74)
    {
        Console.WriteLine(Reprobado);
    }

}
}

