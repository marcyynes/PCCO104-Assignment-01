using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Philippine bank note/coin denomination (1, 2, 5, 10, 20, 50, 100, 200, 500, 1000): ");
        double denomination = 0;

        if (double.TryParse(Console.ReadLine(), out denomination))
        {
            switch (denomination)
            {
                case 0.01:
                case 0.05:
                case 0.25:
                    Console.WriteLine("No Person is found on this denomination.");
                    break;
                case 1:
                    Console.WriteLine("Jose Rizal is found in the Php. 1");
                    break;
                case 5:
                    Console.WriteLine("Emilio Aguinaldo is found in the Php. 5");
                    break;
                case 10:
                    Console.WriteLine("Andres Bonifacio, and Apolinario Mabini is found in the Php. 10");
                    break;
                case 20:
                    Console.WriteLine("Manuel L. Quezon is found in the Php. 20");
                    break;
                case 50:
                    Console.WriteLine("Sergio Osmena is found in the Php. 50");
                    break;
                case 100:
                    Console.WriteLine("Manuel Roxas is found in the Php. 100");
                    break;
                case 200:
                    Console.WriteLine("Diosdado Macapagal is found in the Php. 200");
                    break;
                case 500:
                    Console.WriteLine("Benigno Sr. and Corazon Aquino is found in the Php. 500");
                    break;
                case 1000:
                    Console.WriteLine("Jose Abad Santos, Vicente Lim, and Josefa Llanes Escoda is found in the Php. 1000");
                    break;
                default:
                    Console.WriteLine("Invalid Denomination: {0}", denomination);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}