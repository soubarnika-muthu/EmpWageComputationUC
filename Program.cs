using System;

namespace EmployeeWagecomputaion
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int EMP_WAGE = 0;
            int EMP_PRESENT = 1;
            int EMP_INPUT = random.Next(0,2);
            int FULL_TIME = 0;
            int WAGE_PER_HR = 20;
            if (EMP_INPUT == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
                FULL_TIME = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            EMP_WAGE = FULL_TIME * WAGE_PER_HR;
            Console.WriteLine("Daily Employee Wage is" + EMP_WAGE);
        }
    }
}
