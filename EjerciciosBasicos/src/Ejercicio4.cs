using System.Globalization;

namespace EjerciciosBasicos;

//Un programa que pregunte al usuario un número del 1 al 7 y muestre el día de la semana correspondiente. (switch)
public class Ejercicio4
{
    public Ejercicio4()
    {
        Console.WriteLine("Ingrese un número del 1 al 7");
        int numero = int.Parse(Console.ReadLine());

        if (numero is < 1 or > 7)
        {
            Console.WriteLine("No es un día válido de la semana");
        }

        //Seteando la cultura/Region a idioma Español
        CultureInfo.CurrentCulture = new CultureInfo("es-ES");
        
        String diaSemana = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName((DayOfWeek)numero - 1);
        Console.WriteLine($"El día de la semana es {diaSemana}");
    }
}