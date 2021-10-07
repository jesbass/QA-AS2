using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_AS2
{
    class Program
    {
        //Shows the main menu
        static void showMenu()
        {
            Console.WriteLine("1- Get length");
            Console.WriteLine("2- Set length");
            Console.WriteLine("3- Get width");
            Console.WriteLine("4- Set width");
            Console.WriteLine("5- Get area");
            Console.WriteLine("6- Get perimeter");
            Console.WriteLine("7- Exit");
            Console.WriteLine("Please select an option: ");
        }
        static void Main(string[] args)
        {
            int opt;
            Rectangle rec = new Rectangle();
            do
            {
                showMenu();
                var optString = Console.ReadLine();
                //validate correct data type input
                while (!int.TryParse(optString, out opt))
                {
                    Console.Clear();
                    Console.WriteLine("Wrong option. Please try again");
                    Console.WriteLine();
                    showMenu();
                    optString = Console.ReadLine();
                }
                opt = Int32.Parse(optString);
                if (opt > 0 && opt <= 7)
                {
                    switch (opt)
                    {
                        case 1:
                            Console.WriteLine("Lenght: " + rec.GetLength().ToString());
                            break;
                        case 2:
                            Console.WriteLine("Enter new length: ");
                            var lenString = Console.ReadLine();
                            int lenint;
                            //validate correct data type input
                            while (!int.TryParse(lenString, out lenint))
                            {
                                Console.WriteLine("Wrong input, try again");
                                lenString = Console.ReadLine();
                            }
                            lenint = int.Parse(lenString);
                            rec.SetLength(lenint);
                            break;
                        case 3:
                            Console.WriteLine("Width: " + rec.GetWidth().ToString());
                            break;
                        case 4:
                            Console.WriteLine("Enter new width: ");
                            var widString = Console.ReadLine();
                            int widint;
                            //validate correct data type input
                            while (!int.TryParse(widString, out widint))
                            {
                                Console.WriteLine("Wrong input, try again");
                                widString = Console.ReadLine();
                            }
                            widint = int.Parse(widString);
                            rec.SetWidth(widint);
                            break;
                        case 5:
                            Console.WriteLine("Area: " + rec.GetArea().ToString());
                            break;
                        case 6:
                            Console.WriteLine("Perimeter: " + rec.GetPerimeter().ToString());
                            break;
                    }
                }
                else if (opt != 7)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong option. Please try again");
                    Console.WriteLine();
                }
            } while (opt != 7);
        }
    }
}
