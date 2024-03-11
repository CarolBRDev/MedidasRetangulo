using System;

namespace MedidasTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. A Classe para esta atividade deve conter os atributos Largura e Altura e os Métodos CalcularArea() : double, CalcularPerimetro:double e CalcularDiagonal(): double

            //A  = b . h
            //p = 2 (b + a)
            //diag = raiz quadrada de a2 + b2

            Console.WriteLine("Digite o valor da altura do retangulo: ");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do retangulo: ");
            double altura = double.Parse(Console.ReadLine());

            double area = largura * altura;
            double perimetro = 2 * (largura + altura);
            double diagonal = Math.Sqrt((largura * largura + altura * altura));

            Console.WriteLine($"Área do retângulo: {area}\nPerímetro do retângulo: {perimetro}\nDiagonal do retângulo: {diagonal}");
        }
    }
}
