Console.WriteLine("hola sarita");

// Creamos variables para el dato menor y mayor, el dato recibido, el valor final de mayor y menor.
int mayor = int.MinValue;
int menor = int.MaxValue;
int sarita;

Console.WriteLine("Este programa se hace con el fin de determinar el mayor y menor número ingresado.");
Console.WriteLine("");
Console.WriteLine("INGRESE EL NUMERO DE DATOS: ");

sarita = Convert.ToInt32(Console.ReadLine());

// Creamos un bucle en el cual se le asigna una variable local con valor 0 
// dado el caso que esta sea menor que el valor de la variable se generará de manera incremental en el bucle.
for (int i = 0; i < sarita; i++)
{
    Console.WriteLine("Ingrese el dato número " + (i + 1) + ":");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero > mayor)
    {
        mayor = numero;
    }

    if (numero < menor)
    {
        menor = numero;
    }
}

// Mostramos el dato mayor y menor
Console.WriteLine("===========================================================");
Console.WriteLine("El mayor número ingresado es: " + mayor);
Console.WriteLine("El menor número ingresado es: " + menor);
Console.WriteLine("===========================================================");
