using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.SRP
{
    //Solid principles, different classes for different responsibilities
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private double baseSalary;
        public Employee(string name, int age, double baseSalary)
        {
            Name = name;
            Age = age;
            this.baseSalary = baseSalary;
        }
        public double GetBaseSalary()
        {
            return baseSalary;
        }
        public void SetBaseSalary(double newSalary)
        {
            baseSalary = newSalary;
        }
    }
    public class SalaryCalculator
    {
        public double CalculateSalary(Employee employee, double bonusPercentage)
        {
            double bonus = employee.GetBaseSalary() * bonusPercentage / 100;
            return employee.GetBaseSalary() + bonus;
        }
    }
    public class EmployeePrinter
    {
        public void PrintEmployeeDetails(Employee employee)
        {
            Console.WriteLine($"Employee Name: {employee.Name}, Age: {employee.Age}, Base Salary: {employee.GetBaseSalary()}");
        }
    }
    public class EmailService
    {
        public void SendPayslipEmail(Employee employee, double salary)
        {
            Console.WriteLine($"Sending payslip email to {employee.Name} with salary {salary}");
            // Logic to send email would go here
        }
    }
}
