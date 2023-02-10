namespace EjerciciosBasicos;

//Un programa que sume los números del 1 al 10 y muestre el resultado en la consola. (for)
public class Ejercicio7
{
    public Ejercicio7()
    {
        Console.WriteLine("Sumar los números del 1 al 10");

        //sumar los numeros del 1 al 10 con la formula de suma de matematica discreta

        int acumulador = 0;
        for (int i = 0; i < 10; i++)
        {
            acumulador += i;
        }

        Console.WriteLine("El resultado de la suma es: " + acumulador);
    }
}