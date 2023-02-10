namespace EjerciciosBasicos;

//Un programa que pregunte al usuario si quiere continuar y muestre un mensaje en la consola hasta que responda "no". (while)
public class Ejercicio9
{
    public Ejercicio9()
    {
        bool continuar;
        do
        {
            Console.WriteLine("Desea continuar en este bucle infinito (s/n)");
            continuar = Console.ReadLine().ToLower() == "s";
            Console.Clear();
        } while (continuar);
    }
}