using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExercicioListas
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(Employee employee, double percentage)
        {
            this.Salary += employee.Salary * percentage / 100.0;
        }
    }
}
