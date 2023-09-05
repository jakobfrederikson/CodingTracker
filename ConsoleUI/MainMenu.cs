using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTracker.ConsoleUI
{
    internal class MainMenu
    {
        internal void DisplayMainMenu()
        {
            bool runApp = true;
            UserInput userInput = new UserInput();

            while (runApp)
            {
                Console.Clear();

                Console.WriteLine("0. Start a coding session");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Create a record");
                Console.WriteLine("2. View records");
                Console.WriteLine("3. Update Records");
                Console.WriteLine("4. Delete records");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string userChoice = userInput.GetMenuResponse(5, "Enter your choice: ");

                switch (userChoice)
                {
                    case "0":
                        Console.WriteLine("Starting a coding session.");
                        break;
                    case "1":
                        Console.WriteLine("Create a record");
                        break;
                    case "2":
                        Console.WriteLine("View records");
                        break;
                    case "3":
                        Console.WriteLine("Update records");
                        break;
                    case "4":
                        Console.WriteLine("Delete records");
                        break;
                    case "5":
                        runApp = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }

            }
        }
    }
}
