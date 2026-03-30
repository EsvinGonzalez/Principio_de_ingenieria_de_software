using System;

class EjemploYAGNI
{
    static string Saludar(string nombre)
    {
        return "Hola " + nombre;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Saludar("Esvin"));
    }
}
