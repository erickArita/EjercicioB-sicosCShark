// See https://aka.ms/new-console-template for more information

using EjerciciosBasicos;

bool continuar;

do
{
    Console.WriteLine("Seleccione el ejercicio a ejecutar");
    for (int i = 0; i < 11; i++)
    {
        Console.WriteLine($"{i + 1}. Ejercicio {i + 1}");
    }

    int opcionSeleccionada = int.Parse(Console.ReadLine());


    switch (opcionSeleccionada)
    {
        case 1:
            new Ejercicio1();
            break;
        case 2:
            new Ejercicio2();
            break;
        case 3:
            new Ejercicio3();
            break;
        case 4:
            new Ejercicio4();
            break;
        case 5:
            new Ejercicio5();
            break;
        case 6:
            new Ejercicio6();
            break;
        case 7:
            new Ejercicio7();
            break;
        case 8:
            new Ejercicio8();
            break;
        case 9:
            new Ejercicio9();
            break;
        case 10:
            new Ejercicio10();
            break;

        case 11:
            new Ejercicio11();
            break;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }


    Console.WriteLine("Desea probar otro ejercicio? (s/n)");
    continuar = Console.ReadLine().ToLower() == "s";
    Console.Clear();
} while (continuar);