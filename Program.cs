// Encabezado con el planteamiento del problema
Console.WriteLine("======================================================");
Console.WriteLine("Ejercicio 1 Problemario 1");
Console.WriteLine("Problema: Calcular la potencia electrica de un motor.");
Console.WriteLine("Formula: P = VI. Evaluar si supera los 120 W.");
Console.WriteLine("======================================================\n");

// Variables
double voltaje, corriente, potencia;

// Entrada de datos
Console.Write("Ingrese el voltaje (V): ");
voltaje = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente (A): ");
corriente = Convert.ToDouble(Console.ReadLine());

// Proceso: Calculo de potencia
potencia = voltaje * corriente;

// Salida de resultados
Console.WriteLine($"\nPotencia calculada: {potencia} W");

if (potencia <= 120)
{
    Console.WriteLine("Estado: CONSUMO NORMAL");
}
else
{
    Console.WriteLine("Estado: ADVERTENCIA: CONSUMO ELEVADO");
}

Console.ReadKey();