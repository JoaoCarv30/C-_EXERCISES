using System;
using EX_ARRAY;

namespace EXARRAY // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a quantidade de produtos a ser cadastrado : ");
            int n = int.Parse(Console.ReadLine());

            Produto[] ArrayProdutos = new Produto[n];

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Digite o nome do" + " " + (i + 1) + "º produto : ");
                string name = Console.ReadLine();

                Console.WriteLine("Digite o preço do" + " " + (i + 1) + "º produto : ");
                double price = double.Parse(Console.ReadLine());

                ArrayProdutos[i] = new Produto { productName = name, productPrice = price };
            }
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += ArrayProdutos[i].productPrice;
            }

            double average = sum / n;
            Console.WriteLine("A média de preço dos produtos é : " + average.ToString("F2"));       
        }


    }
}