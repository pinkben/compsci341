using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class UserInterface : IUserInterface
    {
        BusinessLogic bl = new BusinessLogic();

        public string ListEntries()
        {
            return bl.GetCurrentEntries();
        }

        public string AddEntry(string[] entry)
        {
            return bl.AddEntry(entry);
        }

        public string DeleteEntry(string response)
        {
            return bl.RemoveEntry(response);
        }

        public string EditEntry(string[] response)
        {
            return bl.AddEntry(response, true);
        }
    }
}
