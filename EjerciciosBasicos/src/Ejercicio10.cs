namespace EjerciciosBasicos;

public class Ejercicio10
{
    public Ejercicio10()
    {
        Console.WriteLine("Suma de los numeros pares hasta 100");
        int acumulador = 0;
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                acumulador += i;
            }
        }

        Console.WriteLine($"La suma de lus numeros pares del 1 al 100 es: {acumulador}");
    }
}