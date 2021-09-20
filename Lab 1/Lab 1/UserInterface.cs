using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class UserInterface
    {
        BusinessLogic bl = new BusinessLogic();

        public void startMenu()
        {
            Console.Write("Menu \n ==== \n 1. List Entries \n 2. Add Entry" +
                              "\n 3. Delete Entry \n 4. Edit Entry \n 5. Quit \n Choice: ");
            String response = Console.ReadLine();
            if (bl.checkMenuSelection(response))
            {
                switch (response)
                {
                    case "1":
                        listEntries();
                        break;
                    case "2":
                        addEntry();
                        break;
                    case "3":
                        deleteEntry();
                        break;
                    case "4":
                        editEntry();
                        break;
                    case "5":
                        quit();
                        break;
                    default:
                        break;
                }

            }
            else
            {
                Console.Write("INVALID SELECTION.  Please selection a number 1-5. \n");
                startMenu();
            }

        }

        private void listEntries()
        {
            Console.WriteLine("\n Entries \n =======");
        }

        private void addEntry()
        {
            Console.WriteLine("\n Adding Entry \n ==============");
        }

        private void deleteEntry()
        {
            Console.Write("Id to delete: ");
        }

        private void editEntry()
        {
            Console.Write("Id to edit: ");
        }

        private void quit()
        {
            Environment.Exit(0);
        }
    }
}
