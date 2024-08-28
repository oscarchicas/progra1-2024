using System;

namespace ConsoleApp2
  static void Main()
{
    try
    {
        // Solicitar el monto de la actividad económica al usuario
        Console.Write("Introduce el monto de la actividad económica: ");
        double montoActividad = Convert.ToDouble(Console.ReadLine());

        // Calcular el impuesto
        double impuesto = CalcularImpuesto(montoActividad);

        // Mostrar el resultado
        Console.WriteLine("El impuesto a las actividades económicas es: $" + impuesto);
    }
    catch (FormatException)
    {
        Console.WriteLine("Por favor, introduce un número válido.");
    }

    // Esperar a que el usuario presione una tecla antes de cerrar
    Console.WriteLine("Presiona cualquier tecla para salir...");
    Console.ReadKey();
}

static double CalcularImpuesto(double monto)
{
    // Definimos los rangos y valores de la tabla
    var tabla = new (double desde, double hasta, double adicional, double precio)[]
    {
            (0.01, 500, 1.5, 0),
            (500.01, 1000, 1.5, 3),
            (1000.01, 2000, 3, 3),
            (2000.01, 3000, 6, 3),
            (3000.01, 6000, 9, 2),
            (8000.01, 18000, 15, 2),
            (18000.01, 30000, 39, 2),
            (30000.01, 60000, 63, 1),
            (60000.01, 100000, 93, 0.8),
            (100000.01, 200000, 125, 0.7),
            (200000.01, 300000, 195, 0.6),
            (300000.01, 400000, 255, 0.45),
            (400000.01, 500000, 300, 0.4),
            (500000.01, 1000000, 340, 0.3),
            (1000000.01, 99999999, 490, 0.18)
    };

    // Inicializamos el impuesto en 0
    double impuesto = 0;

    // Recorremos la tabla para encontrar el rango correspondiente
    foreach (var (desde, hasta, adicional, precio) in tabla)
    {
        if (monto >= desde && monto <= hasta)
        {
            // Calculamos la parte proporcional según el rango encontrado
            double diferencia = monto - desde;
            impuesto = (diferencia / 1000) * adicional + precio;
            break;
        }
    }

    // Devolvemos el impuesto calculado redondeado a 2 decimales
    return Math.Round(impuesto, 2);
}
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
