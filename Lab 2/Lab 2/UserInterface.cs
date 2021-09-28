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

        public string AddEntry(string[] entry)
        {
            return bl.AddEntry(entry);
        }

        public string DeleteEntry(string response)
        {
            return bl.RemoveEntry(response);
        }

        public void EditEntry(string[] response)
        {
            bl.AddEntry(response, true);
        }
    }
}
