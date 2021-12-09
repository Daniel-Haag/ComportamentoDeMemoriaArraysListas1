using System;
using System.Collections.Generic;

namespace ExercicioListas
{
    class Program
    {
        static void Main()
        {
            int id;
            string name;
            double salary;
            bool repeat = false;
            double percentage;

            Console.WriteLine("How many employees will be registered?");
            int numberOfEmployees = int.Parse(Console.ReadLine());
            List<Employee> employeesList = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"Employee #{i + 1}");
                do
                {
                    Console.Write("ID: ");
                    id = int.Parse(Console.ReadLine());

                    var test = employeesList.Find(x => x.ID == id);

                    if (test != null)
                    {
                        Console.WriteLine("ID already exist, create another one.");
                        repeat = true;
                    }
                    else
                    {
                        repeat = false;
                    }

                } while (repeat);

                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine());

                Employee employee = new Employee(id, name, salary);

                employeesList.Add(employee);
            }

            Console.Write("Enter the employee ID that will have salary increase: ");
            id = int.Parse(Console.ReadLine());

            Employee employee1 = employeesList.Find(x => x.ID == id);

            Console.WriteLine("Enter the percentage: ");
            percentage = double.Parse(Console.ReadLine());

            employee1.IncreaseSalary(employee1, percentage);

            Console.WriteLine("Updated list of employees:");

            foreach(var item in employeesList)
            {
                Console.WriteLine($"{item.ID},{item.Name},{item.Salary}");
            }

            Console.Read();

        }
    }
}
