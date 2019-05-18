using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            CommissionEmployee test = new CommissionEmployee();
            test.Id = 22; 
            test.Salary = 16000;
            test.CommissionRate = 0.07;
            Console.WriteLine($"employee number :{test.Id} has a salary of {test.Salary} and commission is" +
                $" {test.CommissionRate.ToString("P")}");
            Console.ReadKey();
        }
    }
    class Employee
    {
        private int id;
        protected double salary;
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public double Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                const double MINIMUM = 12000;
                if (salary < MINIMUM)
                {
                    salary = MINIMUM;
                }
                else
                {
                    this.salary = value;
                }
            }
        }
    }
    class CommissionEmployee : Employee
    {
        private double commissionRate;
        public double CommissionRate
        {
            get
            {
                return this.commissionRate;
            }
            set
            {
                this.commissionRate = value;
                salary = 0;
            }
        }

    }
}
