using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 1. Declare a dictionary based collection of Employee class objects 
Accept details for Employees  in a loop. Stop accepting based on user input (yes/no)'
Display the Employee with highest Salary
Accept EmpNo to be searched. Display all details for that employee.
Display details for the Nth Employee where N is a number accepted from the user.
2. Create an array of Employee objects. Convert it to a List<Employee>.  Display all the Employees in the list.
3. Create a List<Employee>. Convert it to an array. Display all the array elements.
 */


namespace CollectionDemo
{
    class Program
    {
        static void Main1(string[] args)    //Question1
        {
            Dictionary<int, Employee> dict = new Dictionary<int, Employee>();
            int empno,count=0,n;
            string name;
            decimal basic;
            while (true)
            {
                string ip;
                Console.WriteLine("enter operation : \nExit - no \nAdd Details - yes ");
                ip = Console.ReadLine();
                if (ip == "no")
                {
                    Console.WriteLine("Exit.......");
                    break;
                }
                else if (ip == "yes")
                {
                    //dict.Add(1, new Employee(1, "asd", 1000));
                    Console.WriteLine("add empno, name and basic");
                    empno = Convert.ToInt32(Console.ReadLine());
                    name = Console.ReadLine();
                    basic = Convert.ToDecimal(Console.ReadLine());
                    count++;
                    dict.Add(count, new Employee(empno, name, basic));
                }
            }
            Console.WriteLine("enter empno to display details....");
            empno = Convert.ToInt32(Console.ReadLine());
            foreach (KeyValuePair<int,Employee> item in dict)
            {
                if(item.Value.EmpNo==empno)
                    Console.WriteLine(item.Value);
                //Console.WriteLine(item.Key+" "+item.Value.EmpNo+" "+item.Value.Name+" "+item.Value.Basic);
            }
            Console.WriteLine();
            Console.WriteLine("enter number of employee (n-key)");
            n = Convert.ToInt32(Console.ReadLine());
            foreach (KeyValuePair<int, Employee> item in dict)
            {
                if (item.Key == n)
                    Console.WriteLine(item.Value);
                //Console.WriteLine(item.Key+" "+item.Value.EmpNo+" "+item.Value.Name+" "+item.Value.Basic);
            }
            Console.ReadLine();
        }
        static void Main2()      //Question2
        {
            int empno;
            string name;
            decimal basic;
            Employee[] emp = new Employee[3];
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("add empno, name and basic");
                empno = Convert.ToInt32(Console.ReadLine());
                name = Console.ReadLine();
                basic = Convert.ToDecimal(Console.ReadLine());
                emp[i]= new Employee(empno, name, basic);
            }
            List<Employee> lemp = emp.ToList();
            Console.WriteLine("employee details---------");
            foreach (Employee item in lemp)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        static void Main()      //Question3 and exception handling.....
        {
            int empno;
            string name;
            decimal basic;
            List<Employee> emp= new List<Employee>();
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Console.WriteLine("add empno, name and basic");
                    empno = Convert.ToInt32(Console.ReadLine());
                    name = Console.ReadLine();
                    basic = Convert.ToDecimal(Console.ReadLine());
                    emp.Add(new Employee(empno, name, basic));
                }
                catch(InvalidEmpNo e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(InvalidEmpName e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(InvalidEmpBasic e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Employee[] lemp = emp.ToArray();
            Console.WriteLine("employee details---------");
            foreach (Employee item in lemp)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadLine();
            ArrayList a = new ArrayList();
            
        }

    }

    public class Employee
    {
        Exception ex;
        private int empNo;
        public int EmpNo 
        { 
            get 
            { 
                return empNo; 
            } 
            set 
            { 
                if (value > 0) 
                    empNo = value; 
                else 
                { 
                    ex = new InvalidEmpNo("invalid empno....");
                    throw ex;
                }
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    name = value;
                else
                {
                    ex  = new InvalidEmpName("enter valid employee name");
                    throw ex;
                }


            }
        }
        private decimal basic;
        public decimal Basic 
        { 
            get 
            {
                return basic;
            }
            set
            {
                if (value > 1000)
                    this.basic = value;
                else
                {
                    ex = new InvalidEmpName("enter valid employee basic salary");
                    throw ex;
                }
            }
        }
        public Employee(int empNo=0,string name="noname",decimal basic=1000)
        {
            EmpNo = empNo;
            Name = name;
            Basic = basic;
        }

        public override string ToString()
        {
            return "empNo : " + EmpNo + " Name : " + Name + " Basic : " + Basic;
        }
    }

    class InvalidEmpNo : Exception
    {
        public InvalidEmpNo(string msg) : base(msg)
        {
            //empno
        }
    }
    class InvalidEmpName : Exception
    {
        public InvalidEmpName(string msg) : base(msg)
        {
            //invalid name
        }
    }
    class InvalidEmpBasic : Exception
    {
        public InvalidEmpBasic(string msg) : base(msg)
        {
            //invalid basic
        }
    }
}
