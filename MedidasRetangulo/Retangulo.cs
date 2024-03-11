using System;
using System.Collections.Generic;
using System.Text;

namespace MedidasRetangulo
{
    class Retangulo
    {
        public double largura;
        public double altura;

        public double CalcularArea()
        {
            double area = altura * largura;
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = 2 * (largura + altura);
            return perimetro;
        }

        public double CalcularDiagonal()
        {
            double diagonal = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(largura, 2));
            return diagonal;
        }
    }
}
