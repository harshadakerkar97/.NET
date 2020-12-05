using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] e1 = new Employee[2] { (new Employee("abc",10,14526)),(new Employee("pqr",2,1526))};
            Console.WriteLine("Employee Details => ");
            foreach (Employee e in e1)
            {
                Console.WriteLine(e.EmpNo+" "+e.Name+" "+e.DeptNo+" "+e.Basic );
            }

            Employee e2 = new Employee();
            foreach(Employee e in e1)
            {
                if(e.Basic > e2.Basic)
                {
                    e2 = e;
                }
            }
            Console.WriteLine("Employee details of highest salary : ");
            Console.WriteLine(e2.EmpNo+" "+e2.Name+" "+e2.DeptNo+" "+e2.Basic);
            Console.WriteLine("Enter empno to be searched : ");
            int no = Convert.ToInt32(Console.ReadLine());
            foreach (Employee e in e1)
            {
                if (e.EmpNo == no)
                {
                    e2 = e;
                }
            }
            Console.WriteLine("Employee details : ");
            Console.WriteLine(e2.EmpNo + " " + e2.Name + " " + e2.DeptNo + " " + e2.Basic);
            Console.ReadLine();
            
        }
        public class Employee
        {
            private static int count;
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
            public int DeptNo { get; set; }
            public string Name { get; set; }
            public decimal Basic { get; set; }

            public Employee(string name="noname",int deptno=0,decimal basic=0)
            {
                this.EmpNo = ++count;
                this.Name = name;
                this.DeptNo = deptno;
                this.Basic = basic;
            }
            public Employee()
            {

            }
        }
    }
}

namespace ArrayExamples1
{
    /*
 * Q-2
    CDAC has certain number of batches. each batch has certain number of students
    accept number of batches from the user. for each batch accept number of students.
    create an array to store mark for each student. 
    accept the marks.
    display the marks.
*/
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter number of batches in cdac : ");
            int batches =Convert.ToInt32( Console.ReadLine());
            int[][] record = new int[batches][];
            int n=0;
            for(int i = 0; i < batches; i++)
            {
                Console.WriteLine("enter number of students from batch {0}",i+1);
                n = Convert.ToInt32(Console.ReadLine());
                record[i] = new int[n];
            }

            Console.WriteLine("Enter details of students : ");
            for(int i = 0; i < batches; i++)
            {
                for (int j = 0; j < record[i].Length; j++)
                {
                    Console.WriteLine("Enter marks of batch {0} - student {1} : ",i+1,j+1);
                    record[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("=============================================");
            for (int i = 0; i < batches; i++)
            {
                for (int j = 0; j < record[i].Length; j++)
                {
                    Console.WriteLine("marks of batch {0} - student {1} : {2} ", i+1, j+1, record[i][j]); 
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

namespace ArrayExamples2
{
    /*
     * Create a struct Student with the following properties. Put in appropriate validations.
        string Name
        int RollNo
        decimal Marks
        Create a parameterized constructor.
        Create an array to accept details for 5 students
     */
    class Program
    {
        public static void Main()
        {
            Student []s = new Student[5];
            int rollNo;
            string name;
            decimal marks;
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("enter details of {0} student : ",i+1);
                Console.Write("roll number : ");
                rollNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name : ");
                name = Console.ReadLine();
                Console.Write("Marks : ");
                marks = Convert.ToDecimal(Console.ReadLine());
                s[i] = new Student(rollNo, name, marks);
                Console.WriteLine();
            }
            Console.WriteLine("details of each student : ");
            foreach (Student item in s)
            {
                Console.WriteLine(item.RollNo+" "+item.Name+" "+item.Marks);
            }
            Console.ReadLine();
        }
    }

    public struct Student
    {
        private int rollNo;
        public int RollNo
        {
            get
            {
                return rollNo;
            }
            set
            {
                if(value > 0)
                    rollNo = value;
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
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("enter valid name");
                }
            }
        }
        private decimal marks;
        public decimal Marks { get { return marks; } set { marks = value; } }
        public Student(int rollNo=0,string name="noname",decimal marks=0)
        {
            this.rollNo = 0;
            this.name = null;
            this.marks = 0;
            this.RollNo = rollNo;
            this.Name = name;
            this.Marks = marks;
        }
    }
}
