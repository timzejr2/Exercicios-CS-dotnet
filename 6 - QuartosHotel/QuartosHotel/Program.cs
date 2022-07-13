using System;

namespace QuartosHotel {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Cliente[] c = new Cliente[10];

            for (int i=0; i<n; i++) {
                Console.WriteLine("Rent #" + (i+1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                c[room] = new Cliente(name, email);

            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");

            for (int i=0; i<10; i++) {
                if(c[i] != null) {
                    Console.Write(i + ": ");
                    Console.WriteLine(c[i]);
                }
            }
        }
    }
}
