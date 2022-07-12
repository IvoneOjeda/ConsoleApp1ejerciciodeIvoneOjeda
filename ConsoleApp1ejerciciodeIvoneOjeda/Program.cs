using System;

namespace ConsoleApp1ejerciciodeIvoneOjeda
{
    class Program
    {
        static void Main(string[] args)
        {

            double euros;
            double dolar;
            double mercadoparalelo;
            double pesos;


            Console.Write("Ingresar cantidad de Dolares: ");
            dolar = double.Parse(Console.ReadLine());


            pesos = dolar * 230;
            mercadoparalelo = dolar * 280;
            euros = dolar * 1.17;

            Console.WriteLine($"Se puede comprar por {dolar} Dolar(es) {pesos} Pesos");
            Console.WriteLine($"En el mercado pararlelo equivale a {mercadoparalelo} Pesos");
            Console.WriteLine($"Y se pueden comprar {euros} Euros");


            Console.ReadLine();




        }
    }
}
