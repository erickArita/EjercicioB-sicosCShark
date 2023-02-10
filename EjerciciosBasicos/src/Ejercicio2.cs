namespace EjerciciosBasicos;

// Ejercicio: Escribir un programa que pregunte al usuario por dos números y determine cuál es el mayor.
public class Ejercicio2
{
    public Ejercicio2()
    {
        Console.WriteLine("Ingrese un número");
        int numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine(
            numero1 > numero2
                ? $"{numero1} es mayor que {numero2}"
                : $"{numero2} es mayor que {numero1}"
        );
    }
}