using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product_menu.BL;

namespace Product_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    products[count] = addProduct();
                    count = count + 1;
                }
                else if (option == '2')
                {
                    ShowProducts(products, count);
                }
                else if (option == '3')
                {
                   float sum = TotalWorth(products, count);
                    Console.WriteLine(sum);
                    Console.ReadKey();
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            } while (option != 4);
            Console.WriteLine("Press Enter to Exit..");
            Console.ReadKey();
        }
        static char menu()
        {
            Console.Clear();
            char option;
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Show Products");
            Console.WriteLine("3. Total Store Worth");
            Console.WriteLine("4. For Exit");
            Console.WriteLine("Enter any option");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        static Product addProduct()
        {
            Console.Clear();
            Product p1 = new Product();
            Console.WriteLine("Enter ID");
            p1.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            p1.name = Console.ReadLine();
            Console.WriteLine("Enter Price");
            p1.price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Category");
            p1.category = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Brandname");
            p1.brandname = Console.ReadLine();
            Console.WriteLine("Enter Country");
            p1.country = Console.ReadLine();
            return p1;
        }
        static void ShowProducts(Product[] products,int count)
        {
            Console.Clear();
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("ID {0} Name {1} Price {2},Category {3},BrandName {4},Country {5}",products[x].ID,products[x].name,products[x].price,products[x].category,products[x].brandname,products[x].country);
            }
            Console.WriteLine("Press any key to Exit..");
            Console.ReadKey();
        }
        static float TotalWorth(Product[] products,int count)
        {
            Console.Clear();
            float sum = 0;
            
            for(int x = 0; x < count; x++)
            {
                float product_price = products[x].price;
                sum = sum + product_price;
            }
            return sum;
        }
    }
}
