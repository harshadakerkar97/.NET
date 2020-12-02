using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Manager();
            Employee e1 = new Manager("amol", 10, 20000);
            Employee e2 = new GeneralManager("ram", 11, 3000);
            Employee e3 = new CEO("sham", 12, 500);
            e.show();
            e1.show();
            e2.show();
            e3.show();
            Console.ReadLine();

        }
    }
    public abstract class Employee
    {
        private static int count;
        #region Name property
        private string name;
        public string Name
        {
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("enter valid name....");
                }
            }
            get
            {
                return name;
            }
        }
        #endregion

        #region EmpNo property
        private int empNo;
        public int EmpNo
        {
            private set
            {
                empNo = value;
            }
            get
            {
                return empNo;
            }
        }
        #endregion

        #region DeptNo property
        private short deptNo;
        public short DeptNo
        {
            set
            {
                if(value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("enter valid empno....");
                }
            }
            get
            {
                return deptNo;
            }
        }

        #endregion

        #region abstract Basic property
        public decimal basic;
        public abstract decimal Basic { get;  set; }
        #endregion

        public Employee(string name="none", short deptNo=10)
        {
            EmpNo = ++count;
            Name = name;
            DeptNo = deptNo;
        }

        public abstract decimal CalcNetSalary();
        public void show()
        {
            Console.WriteLine("manager");
            Console.WriteLine("empNo : " + EmpNo);
            Console.WriteLine("empName : " + Name);
            Console.WriteLine("dept no : " + DeptNo);
            Console.WriteLine("basic : " + Basic);
        }

    }

    public class Manager : Employee
    {
        #region designation property
        private string designation;
        public string Designation
        {
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    designation = value;
                }
                else
                {
                    Console.WriteLine("enter valid name....");
                }
            }
            get
            {
                return designation;
            }
        }
        #endregion
        public override decimal Basic 
        {
            set
            {
                if(value > 1000 )
                    basic = value;
                else
                    Console.WriteLine("enter valid basic salary.....");
            }
            get
            {
                return basic;
            }
        }

        public override decimal CalcNetSalary()
        {
            return Basic+1200;
        }

        public Manager(string name,short deptNo,decimal basic=1001,string designation="none"):base(name,deptNo)
        {
            Basic = basic;
            Designation = designation;
        }
        public Manager()
        {
            Console.WriteLine("no para Manager construct......");
        }
        public new void show()
        {
            Console.WriteLine("manager");
            Console.WriteLine("empNo : " + EmpNo);
            Console.WriteLine("empName : " + Name);
            Console.WriteLine("dept no : " + DeptNo);
            Console.WriteLine("basic : " + Basic);
            Console.WriteLine("designation : "+ Designation);
        }
    }

    public class GeneralManager : Manager
    {
        private string perks;
        public string Perks { get; set; }

        public GeneralManager(string name, short deptNo, decimal basic = 1001, string designation = "none",string perks="none") : base(name,deptNo,basic,designation)
        {
            Perks = perks;        
        }

        public GeneralManager()
        {
            Console.WriteLine("generalManager no para construct........");
        }
        public new void show()
        {
            Console.WriteLine("general manager");
            Console.WriteLine("empNo : " + EmpNo);
            Console.WriteLine("empName : " + Name);
            Console.WriteLine("dept no : " + DeptNo);
            Console.WriteLine("basic : " + Basic);
            Console.WriteLine("perks : " + Perks);
        }
    }

    public class CEO : Employee
    {
        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                if (value > 1000)
                    basic = value;
                else
                    Console.WriteLine("enter valid basic salary.....");
            }
        }

        public override sealed decimal CalcNetSalary()
        {
            return Basic + 10000;
        }

        public CEO()
        {
            Console.WriteLine("no param construct");
        }

        public CEO(string name="none",short deptNo=10,decimal basic=1001) : base(name, deptNo)
        {
            Basic = basic;
        }
        public new void show()
        {
            Console.WriteLine("ceo");
            Console.WriteLine("empNo : " + EmpNo);
            Console.WriteLine("empName : " + Name);
            Console.WriteLine("dept no : " + DeptNo);
            Console.WriteLine("basic : " + Basic);
            
        }
    }
}
