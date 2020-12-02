﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main()
        {
            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();

            //Employee o1 = new Employee();
            //Employee o2 = new Employee();
            //Employee o3 = new Employee();
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o4.EmpNo);

            Console.ReadLine();

        }
    }

    class Employee
    {
        private static int count;

        #region properties
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
                    Console.WriteLine("PLEASE ENTER VALID NAME...");
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
            }
            get
            {
                return name;
            }
        }
        private int empNo;
        //read only property
        /*public int EmpNo
        {
            get
            {
                return empNo;
            }
        } */

        public int EmpNo
        {
            private set             //property access specifier 
            {
                empNo = value;
            }
            get
            {
                return empNo;
            }
        }
        
        private decimal basic;
        public decimal Basic
        {
            set
            {
                if(value >= 10000 && value <= 200000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("invalid basic salary");
                }
            }
        }
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
                    Console.WriteLine("Enter valid department number...");
                }
            }
        }
        #endregion

        #region using overloaded constructor
        /*
        public Employee(string name,decimal basic,short deptNo)
        {
            Name = name;
            Basic = basic;
            DeptNo = deptNo;
            empNo = ++count;
            Console.WriteLine("no->"+empNo);
        }

        public Employee(string name,decimal basic)
        {
            Name = name;
            Basic = basic;
            empNo = ++count;
            Console.WriteLine("no->" + empNo);
        }
        public Employee(string name)
        {
            Name = name;
            empNo = ++count;
            Console.WriteLine("no->" + empNo);
        }

        public Employee()
        {
            empNo = ++count;
            Console.WriteLine("no param constructor....");
        }
        */
        #endregion

        #region using default values to constructor
        public Employee(string name="null", decimal basic=10000, short deptNo=10)
        {
            Name = name;
            Basic = basic;
            DeptNo = deptNo;
            EmpNo = ++count;
            Console.WriteLine("no->" + empNo);
        }
        #endregion
        public decimal GetNetSalary()
        {
            return basic + 1200;
        }
    }
}
