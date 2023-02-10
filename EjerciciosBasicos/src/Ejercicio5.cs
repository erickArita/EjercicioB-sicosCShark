namespace EjerciciosBasicos;

//Un programa que pregunte al usuario si quiere comprar una hamburguesa, una ensalada o una pizza y muestre el precio correspondiente. (switch)
public class Ejercicio5
{
    public Ejercicio5()
    {
        Console.WriteLine("Ingrese el número de la opción que desea comprar");
        Console.WriteLine("1. Hamburguesa");
        Console.WriteLine("2. Ensalada");
        Console.WriteLine("3. Pizza");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("El precio de la hamburguesa es $100");
                break;
            case 2:
                Console.WriteLine("El precio de la ensalada es $50");
                break;
            case 3:
                Console.WriteLine("El precio de la pizza es $150");
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}