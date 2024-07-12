using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;
                string[] vet = Console.ReadLine().Split(' ');
                A = double.Parse(vet[0], CI);
                B = double.Parse(vet[1], CI);
                C = double.Parse(vet[2], CI);

                triangulo = A * C / 2.0;
                circulo = 3.14159 * C * C;
                trapezio = (A + B) / 2.0 * C;
                quadrado = B * B;
                retangulo = A * B;

                Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CI));
                Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CI));
                Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CI));
                Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CI));
                Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CI));

            }
        }
    }
}