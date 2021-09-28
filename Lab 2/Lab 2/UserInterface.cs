using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class UserInterface : IUserInterface
    {
        BusinessLogic bl = new BusinessLogic();

        public void StartMenu()
        {
            Console.Write("Menu \n ==== \n 1. List Entries \n 2. Add Entry" +
                              "\n 3. Delete Entry \n 4. Edit Entry \n 5. Quit \n Choice: ");
            String response = Console.ReadLine();
            // If the response is valid, moved forward with that action, otherwise send an error and try again
            if (bl.CheckMenuSelection(response))
            {
                switch (response)
                {
                    case "1":
                        ListEntries();
                        break;
                    case "2":
                        AddEntry();
                        break;
                    case "3":
                        DeleteEntry();
                        break;
                    case "4":
                        EditEntry();
                        break;
                    case "5":
                        Quit();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.Write("INVALID SELECTION.  Please selection a number 1-5. \n");
                StartMenu();
            }

        }

        private void ListEntries()
        {
            Console.WriteLine("\n Entries \n =======");
            String currentEntries = bl.GetCurrentEntries();
            Console.WriteLine(currentEntries);
            StartMenu();
        }

        private void AddEntry()
        {
            string[] entry = new string[5];
            Console.Write("\nAdding Entry \n============== \nClue: ");
            entry[0] = Console.ReadLine();
            Console.Write("Answer: ");
            entry[1] = Console.ReadLine();
            Console.Write("Difficulty: ");
            entry[2] = Console.ReadLine();
            Console.Write("Date (mm/dd/yyyy): ");
            entry[3] = Console.ReadLine();
            String result = bl.AddEntry(entry);
            if (result != "")
            {
                Console.Write("\n" + result + "\n");
                StartMenu();
            }
            else
            {
                Console.Write("\n");
                StartMenu();
            }
        }

        private void DeleteEntry()
        {
            Console.Write("ID to delete: ");
            String response = Console.ReadLine();
            Console.Write(bl.RemoveEntry(response));
            StartMenu();
        }

        private void EditEntry()
        {
            Console.Write("ID to edit: ");
            String response = Console.ReadLine();
            bool valid = bl.EditEntry(response);
            if (!valid)
            {
                Console.Write("Error while editing entry: \nINVALID ID");
            }
            else
            {
                string[] entry = new string[5];
                Console.Write("\nEditing Entry \n============== \nClue: ");
                entry[0] = Console.ReadLine();
                Console.Write("Answer: ");
                entry[1] = Console.ReadLine();
                Console.Write("Difficulty: ");
                entry[2] = Console.ReadLine();
                Console.Write("Date (mm/dd/yyyy): ");
                entry[3] = Console.ReadLine();
                entry[4] = response;
                bl.AddEntry(entry, true);
            }
            StartMenu();
        }

        private void Quit()
        {
            Environment.Exit(0);
        }
    }
}
