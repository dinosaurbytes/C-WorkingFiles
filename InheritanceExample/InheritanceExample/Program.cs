using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Making employees
            Employee ann = new Employee("Ann", 45, 25);
            Employee bob = new Employee("Bob", 35, 30);
            //Make permanment Employee
            PermanentEmployee chris = new PermanentEmployee("Chris", 40, 20, 0.1m);
            //Employee emp = chris;                                           // you are allowed to downgrade
            //PermanentEmployee pemp = (PermanentEmployee) ann;             //not allowed to upgrade - causes InvalidCastException
            PermanentEmployee dana = new PermanentEmployee("Dana", 37.5m, 45, 0.15m);

            //Console.WriteLine(ann);
            //Console.WriteLine(bob);
            //Console.WriteLine(chris);
            //Console.WriteLine(emp);
            //Console.WriteLine(pemp);              //not allowed to upgrade

            Console.WriteLine("\n\nProcess Payroll");
            List <Employee> payroll = new List <Employee>();      //empty list - use the base class
            payroll.Add(ann);
            payroll.Add(bob);
            payroll.Add(chris);
            payroll.Add(dana);

            decimal payrollTotal = 0;
            foreach (Employee e in payroll)
            {
                payrollTotal += e.CalculatePay();           //POLYMORPHISM - same code yields different results depending on object's type
                Console.WriteLine(e);
            }
            Console.WriteLine("\nPayroll Total: " + payrollTotal.ToString());

            



            Console.Write("\n\nPress any key");
            Console.ReadKey();
        }
    }
}
