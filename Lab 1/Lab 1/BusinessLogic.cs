using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class BusinessLogic
    {
        Database data = new Database();

        public bool checkMenuSelection(String selection)
        {
            // Verify that the input for the menu selection is valid
            if (selection.Equals("1") || selection.Equals("2") || selection.Equals("3") ||
                selection.Equals("4") || selection.Equals("5"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String getCurrentEntries() 
        {
            String entries = data.getAllEntries();
            return "";
        }

        public String addEntry(string[] entry)
        {
            if (entry[0].Length > 250 || entry[0].Length < 1)
            {
                return "INVALID CLUE";
            }
            else if (entry[1].Length > 21 || entry[1].Length < 1)
            {
                return "INVALID ANSWER";
            }
            else if (!(entry[2].Equals("1") || entry[2].Equals("2") || entry[2].Equals("3") ||
                     entry[2].Equals("4") || entry[2].Equals("5")))
            {
                return "INVALID DIFFICULTY";
            }
            else
            {
                if (Int32.TryParse(entry[3].Substring(0, 2), out int month) &&
                    entry[3].Substring(2,1).Equals("/") &&
                    Int32.TryParse(entry[3].Substring(3, 2), out int day) &&
                    entry[3].Substring(5,1).Equals("/") &&
                    Int32.TryParse(entry[3].Substring(6), out int year))
                {
                    if ((month < 12 && month > 0) && (day < 32 && day > 0) && (year < 9999 && year > 0))
                    {
                        //pass on to tb, return blank string 
                        return "";
                    }
                    else
                    {
                        return "INVALID DATE";
                    }
                }
                else
                {
                    return "INVALID DATE";
                }
            } 

        }
    }
}
