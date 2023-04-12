using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using login_page.bl;

namespace login_page
{
    class Program
    {
        static int count = 0;

        static void Main(string[] args)
        {
            Login[] login = new Login[10];

            //load data
            string path = "E:\\OOP lab\\Week02\\.vs\\Users.txt";
            StreamReader filevariable = new StreamReader(path);
            string line;
            int num = 0;
            while ((line = filevariable.ReadLine()) != null)
            {
                string[] record = line.Split(',');
                Login s = new Login();
                s.username = record[0];
                s.password = record[1];
                login[count] = s;
                count = count + 1;
            }
            filevariable.Close();

            Login_page(login);
            
        }
        static void Login_page(Login[] login)
        {
            string path = "E:\\OOP lab\\Week02\\.vs\\Users.txt";
            int option;
            do
            {
                //loaddata(path, login);
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Enter Name: ");
                    string Username = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string Password = Console.ReadLine();
                    signIn(login, Username, Password);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter new Name: ");
                    string Username = Console.ReadLine();
                    Console.WriteLine("Enter new Password: ");
                    string Password = Console.ReadLine();
                    login[count] = signUp(path, Username, Password);
                    count = count + 1;
                }
            } while (option < 3);
            Console.ReadKey();
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1. SignIn");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("Enter Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        
        static Login signUp(string path, string Username, string Password)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(Username+ "," + Password);
            file.Flush();
            file.Close();
            Login sinup = new Login();
            sinup.username = Username;
            sinup.password = Password;
            return sinup;
        }
        static void signIn(Login[] login,string Username,string Password)
        {
            bool flag = false;
            for (int x = 0; x < count; x++)
            {
                if (login[x].username==Username && login[x].password==Password)
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }
    }
}
