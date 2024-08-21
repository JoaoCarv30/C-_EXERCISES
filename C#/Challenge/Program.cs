using System;
using System.Collections.Generic;
using Challenge.Entities;

namespace Challenge // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++) {
                Console.WriteLine($"Tax payer #{i+1} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine());
                if(ch == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthSpending = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, annualIncome, healthSpending));
                } else {
                    Console.Write("Number of employees: ");
                    double numberOfEmployees = double.Parse(Console.ReadLine());
                    list.Add(new LegalPerson(name, annualIncome, numberOfEmployees));
                }
            }

            foreach(Person p in list) {
                Console.WriteLine($"{p.Name}: $ {p.CalculateTax().ToString("F2")}");
            }

            double sum = 0;
            foreach(Person p in list) {
                sum += p.CalculateTax();
            }

            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2")}");
        }
    }
}