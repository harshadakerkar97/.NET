using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_in_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Manager();
            Manager e1 = new Manager("amol", 10, 20000);
            GeneralManager e2 = new GeneralManager("ram", 11, 3000);
            CEO e3 = new CEO("sham", 12, 500);

            //e.show();
            e1.insert();
            e2.insert();
            e3.insert();
            //Console.WriteLine(e1);
            //Console.WriteLine(e2);
            //Console.WriteLine(e3);
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
                if (value > 0)
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
        public abstract decimal Basic { get; set; }
        #endregion

        public Employee(string name = "none", short deptNo = 10, decimal basic = 1001)
        {
            EmpNo = ++count;
            Name = name;
            DeptNo = deptNo;
            Basic = basic;
        }

        public abstract decimal CalcNetSalary();
        public void show()
        {
            Console.WriteLine("employee");
            Console.WriteLine("empNo : " + EmpNo);
            Console.WriteLine("empName : " + Name);
            Console.WriteLine("dept no : " + DeptNo);
            Console.WriteLine("basic : " + Basic);
        }
        public override string ToString()
        {
            return "data => " + EmpNo + " " + Name + " " + DeptNo + " " + Basic;
        }
    }

    //Interface
    public interface Interface1
    {
        void insert();
        void delete();
        void update();
    }


    public class Manager : Employee, Interface1
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
                if (value > 1000)
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
            return Basic + 1200;
        }

        public Manager(string name, short deptNo, decimal basic = 1001, string designation = "none") : base(name, deptNo, basic)
        {
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
            Console.WriteLine("designation : " + Designation);
        }
        public override string ToString()
        {
            return "data => " + EmpNo + " " + Name + " " + DeptNo + " " + Basic;
        }

        public virtual void insert()
        {
            Console.WriteLine("Manager insert method");
        }

        public virtual void delete()
        {
            Console.WriteLine("Manager delete method");
        }

        public virtual void update()
        {
            Console.WriteLine("Manager update method");
        }
    }

    public class GeneralManager : Manager
    {
        public string Perks { get; set; }

        public GeneralManager(string name, short deptNo, decimal basic = 1001, string designation = "none", string perks = "none") : base(name, deptNo, basic, designation)
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
        public override string ToString()
        {
            return "data => " + EmpNo + " " + Name + " " + DeptNo + " " + Basic;
        }

        public new void insert()
        {
            Console.WriteLine("General Manager insert method");
        }

        public new void delete()
        {
            Console.WriteLine("General Manager delete method");
        }

        public new void update()
        {
            Console.WriteLine("General Manager update method");
        }
    }

    public class CEO : Employee,Interface1
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

        public CEO(string name = "none", short deptNo = 10, decimal basic = 1001) : base(name, deptNo, basic)
        {
            Console.WriteLine("ceo");
        }
        public new void show()
        {
            Console.WriteLine("ceo");
            Console.WriteLine("empNo : " + EmpNo);
            Console.WriteLine("empName : " + Name);
            Console.WriteLine("dept no : " + DeptNo);
            Console.WriteLine("basic : " + Basic);

        }
        public override string ToString()
        {
            return "data => " + EmpNo + " " + Name + " " + DeptNo + " " + Basic;
        }

        public void insert()
        {
            Console.WriteLine("CEO insert method");
        }

        public void delete()
        {
            Console.WriteLine("CEO delete method");
        }

        public void update()
        {
            Console.WriteLine("CEO update method");
        }
    }
}
