using System;
using System.Collections;
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
            // If the response is valid, moved forward with that action, otherwise send an error and try again
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
            String currentEntries = bl.getCurrentEntries();
            Console.WriteLine(currentEntries);
            startMenu();
        }

        private void addEntry()
        {
            string[] entry = new string[4];
            Console.Write("\nAdding Entry \n============== \nClue: ");
            entry[0] = Console.ReadLine();
            Console.Write("Answer: ");
            entry[1] = Console.ReadLine();
            Console.Write("Difficulty: ");
            entry[2] = Console.ReadLine();
            Console.Write("Date (mm/dd/yyyy): ");
            entry[3] =  Console.ReadLine();
            String result = bl.addEntry(entry);
            if (result != "")
            {
                Console.Write("\n" + result + "\n");
                startMenu();
            }
            else 
            {
                Console.Write("\n");
                startMenu();
            }
        }

        private void deleteEntry()
        {
            Console.Write("ID to delete: ");
            String response = Console.ReadLine();
            Console.Write(bl.removeEntry(response));
            startMenu();
        }

        private void editEntry()
        {
            Console.Write("ID to edit: ");
            String response = Console.ReadLine();
            string[] result = bl.editEntry(response);
            if (result[0].Equals(""))
            {
                Console.Write("Error while editing entry: \nINVALID ID");
            }
            else
            { 
                
            }
            startMenu();
        }

        private void quit()
        {
            Environment.Exit(0);
        }
    }
}
