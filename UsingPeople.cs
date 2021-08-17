using System;

namespace oopstest

{
    /// <summary>
    ///  Creating abstract class Employee.
    /// </summary>
    abstract class Employee
    {
        public int emp_id;
        public double basic_pay;
        public string emp_name, emp_address;

        /// <summary>
        ///  Constructor of class Employee
        /// </summary>
        public Employee(int id, string name, string address, double pay)
        {
            emp_id = id;
            emp_name = name;
            emp_address = address;
            basic_pay = pay;
        }

        /// <summary>
        ///  Method to calculate salary
        /// </summary>
        public abstract double calculateSalary();

    }

    /// <summary>
    ///  Creating class TechnicalEmployee - sub-class of Employee class
    /// </summary>
    class TechnicalEmployee : Employee
    {
        string[] skill;

        /// <summary>
        ///  Constructor of class TechnicalEmployee
        /// </summary>

        public TechnicalEmployee(int id, string name, string address, double pay, string[] skill) : base(id, name, address, pay)
        {

            this.skill = skill;

        }

        /// <summary>
        /// Overriding calculateSalary method to calculate salary of TechnicalEmployee
        /// </summary>

        public override double calculateSalary()
        {
            double hra = 0.12 * this.basic_pay;
            return this.basic_pay + hra;
        }

        /// <summary>
        /// Overriding ToString method
        /// </summary>
        public override string ToString()
        {
            return "ID: " + this.emp_id + "\nName: " + this.emp_name;
        }

    }


    /// <summary>
    /// Creating class Staff - sub-class of Employee class
    /// </summary>
    class Staff : Employee
    {
        string title;

        /// <summary>
        /// Constructor of class TechnicalEmployee
        /// </summary>

        public Staff(int id, string name, string address, double pay, string title) : base(id, name, address, pay)
        {

            this.title = title;
        }

        /// <summary>
        /// Overriding calculateSalary method to calculate salary of Staff
        /// </summary>
        public override double calculateSalary()
        {
            double hra = 0.18 * this.basic_pay;
            return this.basic_pay + hra;
        }

        /// <summary>
        /// Overriding ToString method
        /// </summary>
        public override string ToString()
        {
            return "ID: " + this.emp_id + "\nName: " + this.emp_name;
        }

    }

    /// <summary>
    /// Creating class UsingPeople - driver class
    /// </summary>
    class UsingPeople
    {
        static void Main()
        {
            Employee emp;
            emp = new TechnicalEmployee(1, "surbhi", "Bokaro", 15.5, new string[] { "C#", "Python" });
            Console.WriteLine(emp.ToString() + '\n' + emp.calculateSalary());
            emp = new TechnicalEmployee(2, "Shristi", "Patna", 20, new string[] { "Java", "javascript" });
            Console.WriteLine(emp.ToString() + '\n' + emp.calculateSalary());
            emp = new Staff(3, "Akash", "Patna", 18, "Electrician");
            Console.WriteLine(emp.ToString() + '\n' + emp.calculateSalary());
        }
    }
}
