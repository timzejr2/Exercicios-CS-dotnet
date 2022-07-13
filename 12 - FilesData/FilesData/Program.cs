using System;
using System.Globalization;
using System.IO;
using Entities;

namespace FilesData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\DIO\Projetos\dotnet\Files\";
            
            try
            {
                string[] lines = File.ReadAllLines(filePath + @"\Summary.csv");

                Directory.CreateDirectory(filePath + @"\out");

                using (StreamWriter sw = File.AppendText(filePath + @"\out\total.csv"))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quant = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quant);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}