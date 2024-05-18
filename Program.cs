using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la cantidad de empleados:");
        int n = int.Parse(Console.ReadLine());

        int contador = 0;
        int contador100a300 = 0;
        int contadorMas300 = 0;
        int gastoTotal = 0;

        while (contador < n)
        {
            Console.Write($"Ingrese el sueldo del empleado {contador + 1}: $");
            int sueldo = int.Parse(Console.ReadLine());

            gastoTotal += sueldo;

            if (sueldo >= 100 && sueldo <= 300)
            {
                contador100a300++;
            }
            else if (sueldo > 300)
            {
                contadorMas300++;
            }

            contador++;
        }

        Console.WriteLine($"Empleados que cobran entre $100 y $300: {contador100a300}");
        Console.WriteLine($"Empleados que cobran más de $300: {contadorMas300}");
        Console.WriteLine($"La empresa gasta un total de: ${gastoTotal} en sueldos.");
    }
}
