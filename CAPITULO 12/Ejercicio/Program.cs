using System;
using System.Diagnostics;
using System.IO;

int a = 5;
int b = 10;
int c = 0;
int r = 0;

// Pedimos el dato al usuario
Console.WriteLine("Dame el valor del divisor");
a = Convert.ToInt32(Console.ReadLine());

// Codigo peligroso, lo colocamos en try para 
// administrar la excepcion
try
{
    // Hacemos la division
    r = b / a;
}
catch (DivideByZeroException e)
{
    // Aqui colocamos el codigo que salva la aplicacion
    Console.WriteLine("No es posible dividir entre cero");
    r = 0;
}
finally
{
    // Mostramos el resultado
    Console.WriteLine("El resultado es {0}", r);
}

// Mostramos el resultado 5 veces
for (int n = 0; n < 5; n++)
{
    Console.WriteLine("El resultado es {0}", r);
}

// Invocamos la función
MuestraValor(a);

// Ejemplo de depuración paso a paso
Debug.WriteLine("Inicio del programa");

int[] numeros = { 1, 2, 3 };
int indice = 3;

// Buscamos las excepciones de los arreglos en MSDN
try
{
    int numero = numeros[indice];
    Console.WriteLine(numero);
}
catch (IndexOutOfRangeException e)
{
    Debug.WriteLine("Error: El índice está fuera del rango del arreglo");
}

// Buscamos las excepciones de los streams en MSDN
try
{
    FileStream archivo = File.Open("archivo.txt", FileMode.Open);
    StreamReader lector = new StreamReader(archivo);
    Console.WriteLine(lector.ReadLine());
    lector.Close();
    archivo.Close();
}
catch (FileNotFoundException e)
{
    Debug.WriteLine("Error: El archivo no se encontró");
}
catch (IOException e)
{
    Debug.WriteLine("Error: Problema de lectura del archivo");
}

// Buscamos las excepciones del método WriteLine() en MSDN
try
{
    int resultado = 10 / 2;
    Console.WriteLine("El resultado es {0}", resultado);
    resultado = 10 / 0;
    Console.WriteLine("El resultado es {0}", resultado);
}
catch (DivideByZeroException e)
{
    Debug.WriteLine("Error: No es posible dividir entre cero");
}

Debug.WriteLine("Fin del programa");


static void MuestraValor(int n)
{
    Console.WriteLine("El resultado es {0}", n);
}