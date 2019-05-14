using Exercicio_Employees2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;


namespace Exercicio_Employees2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EMPLOYEES          
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employees> list = new List<Employees>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee # {i} data: ");
                Console.Write("Outsourced (y/n)? ");
                string res = Console.ReadLine();
                if(res  == "y" || res == "YES" || res == "s" || res == "SIM")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per Hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Addtional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                   
                    list.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));
                    Console.WriteLine();
                }
                else if(res == "n" || res == "NO" || res == "NAO")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per Hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                   
                    list.Add(new Employees(name, hours, valuePerHour));
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("Respota Errada!");
                }
                               
            }

            Console.WriteLine("PAYMENTS: ");
            foreach(Employees emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.payment().ToString("F2", CultureInfo.InvariantCulture));
            }
            
            #endregion
        }
    }
}
