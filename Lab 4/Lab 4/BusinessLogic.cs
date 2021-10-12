using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class BusinessLogic : IBusinessLogic
    {
        Database data = new Database();

        // This method get all current entries
        public String GetCurrentEntries()
        {
            StringBuilder sb = new StringBuilder();
            String allEntries = "";
            List<Entry> Entries = data.GetAllEntries();
            if (Entries == null)
            {
                return allEntries;
            }
            else
            {
                foreach (Entry entry in Entries)
                {
                    sb.Append(entry.Id + ":");
                    sb.AppendLine(" Clue: " + entry.Clue);
                    sb.AppendLine("   Answer: " + entry.Answer);
                    sb.AppendLine("   Difficulty: " + entry.Difficulty);
                    sb.AppendLine("   Data: " + entry.Date);
                    sb.AppendLine("------------------------------");
                }
                return sb.ToString();
            }
        }

        // This method handles adding entries
        public String AddEntry(string[] entry, bool edit = false)
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
                    entry[3].Substring(2, 1).Equals("/") &&
                    Int32.TryParse(entry[3].Substring(3, 2), out int day) &&
                    entry[3].Substring(5, 1).Equals("/") &&
                    Int32.TryParse(entry[3].Substring(6), out int year))
                {
                    if ((month < 13 && month > 0) && (day < 32 && day > 0) && (year < 10000 && year > 0))
                    {
                        //pass on to db, return blank string
                        var validEntry = new Entry
                        {
                            Clue = entry[0],
                            Answer = entry[1],
                            Difficulty = entry[2],
                            Date = entry[3],
                            Id = entry[4]
                        };
                        data.AddEntry(validEntry, edit);
                        return "";
                    }
                    else
                    {
                        return "INVALID DATE";
                    }
                }
                else
                {
                    return "Error while adding entry: \nINVALID DATE\n";
                }
            }

        }

        public String RemoveEntry(string id)
        {
            if (Int32.TryParse(id, out int idNum) && idNum > 0)
            {
                if (data.RemoveEntry(idNum))
                {
                    return "";
                }
                else
                {
                    return "UNABLE TO FIND ID";
                }
            }
            else
            {
                return "INVALID ID";
            }
        }

        public bool EditEntry(string id)
        {
            if (Int32.TryParse(id, out int idNum) && idNum > 0)
            {
                Entry entry = data.GetEntry(idNum);
                if (entry == null)
                {
                    return false;
                }
                else
                {
                    // remove the old entry from the database
                    data.RemoveEntry(idNum);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
