namespace EjerciciosBasicos;

// Ejercicio: Escribir un programa que pregunte al usuario por un número y determine si es positivo, negativo o cero. (if)
public class Ejercicio1
{
    public Ejercicio1()
    {
        Console.WriteLine("Ingrese un número para saber si es positivo, 0 o negativo");
        int numero = int.Parse(Console.ReadLine());

        if (numero == 0)
        {
            Console.WriteLine("El número es 0");
            return;
        }

        string signo = numero > 0 ? "positivo" : "negativo";

        Console.WriteLine($"""{numero} es un número {signo} """);
    }
}