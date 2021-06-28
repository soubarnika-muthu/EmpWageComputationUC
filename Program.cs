using System;

namespace EmployeeWagecomputaion
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int EMP_PRESENT = 1;
            int EMP_INPUT = random.Next(0,2);
            if (EMP_INPUT == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
