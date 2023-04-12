using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week02_OOP_LAB.BL;

namespace Week02_OOP_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task2();
            //Task3();
            Task4();
            Console.Read();
        }
        static void Task2()
        {
            Student s1 = new Student();
            s1.name = "Mudasir";
            s1.roll_no = 77;
            s1.cgpa = 3.25F;
            Console.WriteLine("Name {0} Roll no {1} Cgpa {2}", s1.name, s1.roll_no, s1.cgpa);
        }
        static void Task3()
        {
            //first object
            Student s1 = new Student();
            s1.name = "Mudasir";
            s1.roll_no = 77;
            s1.cgpa = 3.25F;
            Console.WriteLine("Name {0} Roll no {1} Cgpa {2}", s1.name, s1.roll_no, s1.cgpa);
            //second object
            Student s2 = new Student();
            s2.name = "Ali";
            s1.roll_no = 100;
            s2.cgpa = 3.75F;
            Console.WriteLine("Name {0} Roll no {1} Cgpa {2}", s2.name, s2.roll_no, s2.cgpa);
        }
        static void Task4()
        {
            Student s3 = new Student();
            Console.WriteLine("Enter Name: ");
            s3.name = Console.ReadLine();
            Console.WriteLine("Enter roll no.");
            s3.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CGPA ");
            s3.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Name {0} Roll no {1} Cgpa {2}", s3.name, s3.roll_no, s3.cgpa);
        }
    }
}
