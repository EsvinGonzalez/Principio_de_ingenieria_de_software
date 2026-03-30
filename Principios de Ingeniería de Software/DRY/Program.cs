using System;
class EjemploDRY
{
    static double CalcularTotal(double precio, double cantidad)
    {
        return precio * cantidad;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(CalcularTotal(10, 2));
        Console.WriteLine(CalcularTotal(5, 3));
    }
}