using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool control = true;

            Student student1 = new Student(1, "Emil", "Qallacov", 50, 40, 73, "BHOS");
            
            Console.WriteLine("WELCOME TO THE STUDENT APPLICATION..." +
                "ENTER THE PROCESS...");
            

            while(control)
            {
                Console.WriteLine();
                EnterProcess();
                Console.Write("ENTER=>");
                string option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        Console.WriteLine("Student Information:");
                        student1.ShowStudentData();
                        break;
                    case "2":
                        double gpa = student1.FindStudentGPA();
                        Console.WriteLine("Student gpa is " + gpa);
                        break;
                    case "3":
                        Console.WriteLine("Student University:");
                        student1.StudentUniversity();
                        break;
                    case "4":
                        Console.WriteLine("exit...");
                        control = false;
                        break;
                }
            }

        }
        static void EnterProcess()
        {
            Console.WriteLine("1-Show student information!");
            Console.WriteLine("2-Show student GPA!");
            Console.WriteLine("3-Show student university!");
            Console.WriteLine("4-Exit...");
        }
    }

    public class Student
    {
        private int StudentId;
        private string FirstName;
        private string LastName;
        private double quiz1;
        private double quiz2;
        private double final;
        private string UniversityName;

        public Student(int StudentId_, string FirstName_, string LastName_, double quiz1_, double quiz2_, double final_, string UniversityName_)
        {
            StudentId = StudentId_;
            FirstName = FirstName_;
            LastName = LastName_;
            quiz1 = quiz1_;
            quiz2 = quiz2_;
            final = final_;
            UniversityName = UniversityName_;
        }

        public void ShowStudentData()
        {
            Console.WriteLine("SHOW STUDENT ID:" + StudentId);
            Console.WriteLine("SHOW FIRST NAME:" +  FirstName);
            Console.WriteLine("SHOW LAST NAME:" + LastName);
            Console.WriteLine("SHOW QUIZ1 VALUE:" + quiz1);
            Console.WriteLine("SHOW QUIZ2 VALUE:" + quiz2);
            Console.WriteLine("SHOW FINAL VALUE:" + final);
            Console.WriteLine("SHOW UNIVERSITY NAME:" + UniversityName);
        }

        public double FindStudentGPA()
        {
            double result = quiz1 * 0.2 + quiz2 * 0.2 + final * 0.6;
            return result;
        }
        public void StudentUniversity()
        {
            string uni;
            uni = UniversityName;
            Console.WriteLine("student univerity is " + uni);
        }
    }

}
