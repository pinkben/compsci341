using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class UserInterface : IUserInterface
    {
        BusinessLogic bl = new BusinessLogic();

        public string ListEntries()
        {
            return bl.GetCurrentEntries();
        }

        public void AddEntry(string[] entry)
        {
            bl.AddEntry(entry);
        }

        public void DeleteEntry(string response)
        {
            bl.RemoveEntry(response);
        }

        public void EditEntry()
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
        }
    }
}
