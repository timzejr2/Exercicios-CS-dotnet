using System;
using ProdutosCadastrados.Entities;
using System.Collections.Generic;

namespace ProdutosCadastrados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> p = new List<Product>();

            Console.Write("Enter the number of products: ");
            int q = int.Parse(Console.ReadLine());

            for(int i = 0; i < q; i++)
            {
                Console.WriteLine($"Product #{q} data: ");
                Console.Write("Common, used or imported (c/u/i)?");
                char productType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(productType == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    p.Add(new ImportedProduct(name, price, customsFee));
                }
                else if(productType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    p.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if(productType == 'c')
                {
                    p.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product prod in p)
            {
                Console.WriteLine(prod.priceTag());
            }
            
        }
    }
}
