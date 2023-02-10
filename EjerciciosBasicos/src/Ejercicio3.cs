namespace EjerciciosBasicos;

//Un programa que pregunte al usuario su género y muestre un mensaje en la consola si es hombre o mujer. (if)

public class Ejercicio3
{
    public Ejercicio3()
    {
        Console.WriteLine("Ingrese su género (M/F)");
        string genero = Console.ReadLine().ToLower();


        if (genero is not ("m" or "f"))
        {
            Console.WriteLine("Género inválido");
            return;
        }

        if (genero == "m")
        {
            Console.WriteLine("Usted es un hombre");
        }
        else
        {
            Console.WriteLine("Usted es mujer");
        }
    }
}