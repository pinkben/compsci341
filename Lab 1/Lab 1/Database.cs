using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab_1
{
    class Database
    {
        string fileName = "Database.json";

        public String getAllEntries() 
        {
            if (File.Exists(fileName))
            {
                return File.ReadAllText(fileName);
            }
            else
            {
                return "";
            }
        }

        public String getEntry(int id) 
        {
            return "";
            /*if (false)
            {
                return "";
            }
            else
            {
                return "";
            }*/
        }

        public void addEntry(Entry entry)
        {
            Entry newEntry = entry;
            int idNum;
            if (File.Exists(fileName))
            {
                string fileJsonString = File.ReadAllText(fileName);
                Entry lastEntry = JsonSerializer.Deserialize<Entry>(fileJsonString);
                if (Int32.TryParse(lastEntry.Id, out int lastId))
                {
                    idNum = lastId + 1;
                    newEntry.Id = idNum.ToString();
                }

            }
            else
            {
                newEntry.Id = "1";
            }
            string newJsonString = JsonSerializer.Serialize(newEntry);
            File.AppendAllText(fileName, newJsonString);
        }

        public bool removeEntry(int id)
        {
            return true;
            /*if (false)
            {
                return true;
            }
            else
            {
                return false;
            }*/
        }
    }
}
