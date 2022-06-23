// See https://aka.ms/new-console-template for more information
namespace CheckEmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Review 2 Employee Wage Computation Problems");
            CheckPartFullTimeMonthlyWage checkPartFullTimeMonthlyWage = new CheckPartFullTimeMonthlyWage();
            checkPartFullTimeMonthlyWage.CheckEmpolyeeWage();
        }
    }
}

//Result

//Welcome To Review 2 Employee Wage Computation Problems
//Employee Daily Wage = 160
//Monthly Wage = 1200