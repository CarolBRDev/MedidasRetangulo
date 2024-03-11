using System;

namespace MedidasRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();
            
            Console.WriteLine("Digite o valor da altura do retangulo: ");
            x.altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da largura do retangulo: ");
            x.largura = double.Parse(Console.ReadLine());

            double area = x.CalcularArea();
            double perimetro = x.CalcularPerimetro();
            double diagonal = x.CalcularDiagonal();

            Console.WriteLine($"Área do retângulo: {area}\nPerímetro do retângulo: {perimetro}\nDiagonal do retângulo: {diagonal}");
        }
    }
}
