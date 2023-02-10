namespace EjerciciosBasicos;

//Un programa que sume los números del 1 al 10 y muestre el resultado en la consola. (for)
public class Ejercicio8
{
    public Ejercicio8()
    {
        Console.WriteLine("Ingrese un número del cual quiera calcular el factorial");

        int fac = int.Parse(Console.ReadLine());

        int acumulador = 1;

        for (int i = 1; i <= fac; i++)
        {
            acumulador *= i;
        }

        Console.WriteLine($"El factorial es: {acumulador}");
    }
}