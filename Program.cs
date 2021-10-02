using System;

namespace midtest2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Digital Library"); //หน้าต่างเเสดงข้อความWelcome to Digital Library
            Console.WriteLine("------------------");
            Console.WriteLine("1.Login");//หน้าต่างเเสดงข้อความ1.Login
            Console.WriteLine("2.Register");//หน้าต่างเเสดงข้อความ2.Register
            int selectmenu = 1 - 2;  //กำหนดให้ผู้ใช้งานเลือกได้2เลข คือ1หรือ2 
            Console.Write("Select Menu: "); //ผู้ใช้กรอกเลข1หรือ2 
            selectmenu = int.Parse(Console.ReadLine()); //ผู้ใช้กรอกเลข1หรือ2

            if (selectmenu == 2) //เช็คว่าต้องการ Login หรือ Register //อันนี้เป็นเงื่อนไขของส่วนที่ต้องการRegister
            {
                Console.WriteLine("Register new Person"); //เเสดงข้อความ Register new Personหรือจากที่ผู้ใช้งานกรอกเลข2
                Console.WriteLine("-------------");

                string name;
                Console.Write("Input name: "); //เเสดงข้อความให้กรอกชื่อ
                name = Console.ReadLine();
                int password;
                Console.Write("Input Password: ");  //เเสดงข้อความให้กรอกรหัส
                password = int.Parse(Console.ReadLine());

                int inputtype = 1 - 2;  //ให้ผู้ใช้งานเลือกว่าเป็น 1 = Student หรือ 2 = Employee
                Console.Write("Input User Type 1 = Student, 2 = Employee: "); //เเสดงข้อความInput User Type 1 = Student, 2 = Employee:
                inputtype = int.Parse(Console.ReadLine()); //รับค่าจากผู้ใช้มาว่าถ้า 1 = Student, 2 = Employee
                if (inputtype == 1)  //1 = Student จะขึ้นหน้าตาให้กรอกรหัสStudent ID
                {
                    Console.Write("Student ID: ");
                    Console.ReadLine();
                }
                else  //2 = Employee จะขึ้นหน้าตาให้กรอกรหัสEmployee ID
                {
                    //int Employeeid;
                    Console.Write("Employee ID: ");
                    Console.ReadLine();
                }
            }

            else //เงื่อนไขส่วนของการlogin  ถ้าผู้ใช้งานกรอกหมายเลข1 (Login)
            {
                Console.WriteLine("Login Screen");  //เเสดงข้อความLogin Screen
                Console.WriteLine("--------");
                string name;
                Console.Write("Input name: ");  //เเสดงข้อความ Input name: พร้อมกับให้ผู้ใช้งานกรอกชื่อ
                name = Console.ReadLine(); 
                int password;
                Console.Write("Input Password: ");  //เเสดงข้อความ Input Password: พร้อมกับให้ผู้ใช้งานกรอกรหัส
                password = int.Parse(Console.ReadLine());
                   //เช็คว่าloginเป็นนักเรียนหรือพนักงาน
            }
            
        }
    }
    class Person  //สร้างคลาสPerson
    {
        public string name;
        public string password;

        public Person(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
    class Student //สร้างคลาสStudent
    {
        public string studentid;

        public Student(string name, string password) 
        {
            this.studentid = studentid;
        }

    class Employee 
    {
        public string EmployeeID;

        public Employee(string name, string password, string EmployeeID)
        {
            this.EmployeeID = EmployeeID;
        }
    }
        class PersonList
        {
           public  string Booklist;

            public PersonList()
            {
                //this.Booklist = PersonList();
            }

            
        }
    }
}
