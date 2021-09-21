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
            return entries;
        }

        public String addEntry(string[] entry)
        {
            if (entry[0].Length > 250 || entry[0].Length < 1)
            {
                return "Error while adding entry: \nINVALID CLUE";
            }
            else if (entry[1].Length > 21 || entry[1].Length < 1)
            {
                return "Error while adding entry: \nINVALID ANSWER";
            }
            else if (!(entry[2].Equals("1") || entry[2].Equals("2") || entry[2].Equals("3") ||
                     entry[2].Equals("4") || entry[2].Equals("5")))
            {
                return "Error while adding entry: \nINVALID DIFFICULTY";
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
                        //pass on to db, return blank string
                        var validEntry = new Entry
                        {
                            Clue = entry[0],
                            Answer = entry[1],
                            Difficulty = entry[2],
                            Date = entry[3] 
                        };
                        data.addEntry(validEntry);
                        return "";
                    }
                    else
                    {
                        return "Error while adding entry: \nINVALID DATE";
                    }
                }
                else
                {
                    return "Error while adding entry: \nINVALID DATE";
                }
            } 

        }

        public String removeEntry(string id)
        {
            if (Int32.TryParse(id, out int idNum))
            {
                if (data.removeEntry(idNum))
                {
                    return "\n";
                }
                else
                {
                    return "Error while removing entry: \nUNABLE TO FIND ID";
                }
            }
            else
            {
                return "Error while removing entry: \nINVALID ID";
            }
        }

        public string[] editEntry(string id)
        {
            string[] result = new string[4];
            if (Int32.TryParse(id, out int idNum))
            {
                if (false)
                {
                    return result;
                }
                else
                {

                    return result;
                }
            }
            else
            {
                return result;
            }
        }
    }
}
