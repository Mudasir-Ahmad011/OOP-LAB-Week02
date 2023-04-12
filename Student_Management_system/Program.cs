using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Management_system.BL;
namespace Student_Management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] s = new Students[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    s[count] = addStudent();
                    count = count + 1;
                }
                else if (option == '2')
                {
                    viewStudent(s, count);
                }
                else if (option == '3')
                {
                    topStudent(s, count);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            } while (option != '4');
            Console.WriteLine("Press Enter to Exit..");
            Console.ReadKey();
        }
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("Press 1 For adding a student");
            Console.WriteLine("Press 2 For view students");
            Console.WriteLine("Press 3 For Top three students");
            Console.WriteLine("Press 4 For Exit");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static Students addStudent()
        {
            Console.Clear();
            Students s1 = new Students();
            Console.WriteLine("Enter Name: ");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter Roll no: ");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department: ");
            s1.department = Console.ReadLine();
            Console.WriteLine("Is Hostalide (y || n)");
            s1.isHostalide = char.Parse(Console.ReadLine());
            return s1;
        }
        static void viewStudent(Students[] s,int count)
        {
            Console.Clear();
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Name {0} Roll no {1} CGPA {2} Department {3} IsHostalide {4}",s[i].name,s[i].roll_no,s[i].cgpa,s[i].department,s[i].isHostalide);
            }
            Console.WriteLine("Press Any key to continue");
            Console.ReadKey();
        }
        static void topStudent(Students[] s, int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No record present");
            }
            else if (count == 1)
            {
                viewStudent(s, 1);
            }
            else if (count == 2)
            {
                for (int x = 0; x < 2; x++)
                {
                    int index = largest(s, x, count);
                    Students temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
                viewStudent(s, 2);
            }
            else
            {
                for (int x = 0; x < 3; x++)
                {
                    int index = largest(s, x, count);
                    Students temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
                viewStudent(s, 3);
            }
        }
           static int largest(Students[] s,int start,int end)
            {
                int index = start;
                float large = s[start].cgpa;
                for(int x = start; x < end; x++)
                {
                    if (large < s[x].cgpa)
                    {
                        large = s[x].cgpa;
                        index = x;
                    }
                }
                return index;
            }
        }
    }

