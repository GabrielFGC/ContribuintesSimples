using System;
using System.Collections.Generic;
using System.Globalization;
using DadosDeContribuintes.Entities;

namespace DadosDeContribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Peoples> dados = new List<Peoples>();

            Console.Write("Enter the number of tax payers: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"\nTax payer {i+1}º data: ");

                Console.Write("Individual ou coompany (i/c): ");
                char ic = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (ic == 'i' || ic == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    dados.Add(new PeopleIndividual(name, anual, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    dados.Add(new PeopleCompany(name, anual, employees));
                }
            }

            double total = 0;

            Console.WriteLine("\nTaxes Paid: ");

            foreach (Peoples item in dados)
            {
                Console.WriteLine(item);
                total += item.Tax();
            }

            Console.WriteLine($"Total taxes: ${total.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
