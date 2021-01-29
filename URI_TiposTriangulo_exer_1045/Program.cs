using System;
using System.Collections.Generic;
using System.Globalization;
namespace URI_TiposTriangulo_exer_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            double[] vet = new double[3];
            string[] value = Console.ReadLine().Split();
            vet[0] = double.Parse(value[0],CultureInfo.InvariantCulture);
            vet[1] = double.Parse(value[1],CultureInfo.InvariantCulture);
            vet[2] = double.Parse(value[2],CultureInfo.InvariantCulture);
            int i = 0;
            Array.Sort(value);
            if (vet[0] > 0 && vet[1] > 0 && vet[2] > 0)
            {
                list.Add(vet[0]);
                list.Add(vet[1]);
                list.Add(vet[2]);

                list.Sort();
                list.Reverse();
                foreach (double s in list)
                {
                    vet[i] = s;
                    Console.WriteLine(vet[i]);
                    i++;
                }
                if(vet[0] >= vet[1] + vet[2])
                {
                    Console.WriteLine("NAO FORMA TRIANGULO");
                }
                if(vet[0] * vet[0] == vet[1] * vet[1] + vet[2] * vet[2])
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if ((vet[0] * vet[0]) > ((vet[1] * vet[1]) + (vet[2] * vet[2])))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (vet[0] * vet[0] < vet[1] * vet[1] + vet[2] * vet[2])
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if(vet[0] == vet[1] && vet[0] == vet[2])
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                if(vet[0] == vet[1] && vet[1] != vet[2] || vet[1] == vet[2] && vet[0] != vet[2] || vet[0] == vet[2] && vet[0] != vet[1]) 
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
