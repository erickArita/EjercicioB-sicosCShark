namespace EjerciciosBasicos;

//Un programa que muestre la tabla de multiplicar del número dado por el usuario hasta el 10. (while)
public class Ejercicio11
{
    public Ejercicio11()
    {
        Console.WriteLine("Ingrese la la tabla del número que quiere ver");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($" {num} * {i} = {num * i}");
        }
    }
}