using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
1. decimal SimpleInterest(decimal P, decimal N, decimal R) -> returns calculated SimpleInterest
2. bool IsGreater(int a, int b) -> returns true if a is > b
3. decimal GetBasic(Employee e) -> returns the Basic salary of the employee
4. bool IsEven(int num) -> returns true if the number is an even number
5. bool IsGreaterThan10000(Employee e) -> returns true if the Basic Salary is > 10000
 */

namespace LambdaFunctionAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. simple interest.....
            Func<decimal, decimal, decimal,decimal> SimpleInterest = (p, n, r) => n*p*r;
            Console.WriteLine("simple interest : "+ SimpleInterest(2000,4,5));
            //2. greater...........
            Func<int, int, bool> IsGreater = (a, b) => a > b;
            Console.WriteLine("a > b => "+IsGreater(6,3));
            //3. getBasic........
            Employee e = new Employee(1, "ram", 20000);
            Func<Employee, decimal> GetBasic = (emp) => emp.Basic;
            Console.WriteLine(GetBasic(e));
            //4. even no
            Predicate<int> IsEven = (a) => a % 2 == 0;
            Console.WriteLine("is even = "+IsEven(20));
            //5.  bool IsGreaterThan10000(Employee e)
            Predicate<Employee> IsGreaterThan10000 = (emp) => e.Basic > 10000;
            Console.WriteLine("IsGreaterThan10000 : "+IsGreaterThan10000(e));
            Console.ReadLine();
        }
    }
    class Employee
    {
        private int empNo;
        public int EmpNo
        {
            set
            {
                if(value > 0)
                    empNo = value;
                else
                    Console.WriteLine("invalid empno");
            }
            get
            {
                return empNo;
            }
        }
        public decimal Basic { get; set; }
        public string Name { get; set; }

        public Employee(int empno=1,string name="noname",decimal basic=1000)
        {
            this.EmpNo = empno;
            this.Name = name;
            this.Basic = basic;
        }
    }
}
