using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab_1
{
    class Database : IDatabase
    {
        string fileName = "Database.json";
        List<Entry> Entries = new List<Entry>();

        public List<Entry> getAllEntries()
        {
            if (File.Exists(fileName))
            {
                string fileJsonString = File.ReadAllText(fileName);
                Entries.Clear();
                Entries = JsonSerializer.Deserialize<List<Entry>>(fileJsonString);
                return Entries;
            }
            else
            {
                return null;
            }
        }

        public Entry getEntry(int id)
        {
            if (File.Exists(fileName))
            {
                string fileJsonString = File.ReadAllText(fileName);
                Entries.Clear();
                Entries = JsonSerializer.Deserialize<List<Entry>>(fileJsonString);
                if (id > Entries.Count)
                {
                    return null;
                }
                else
                {
                    return Entries.ElementAt<Entry>(id - 1);
                }
            }
            else
            {
                return null;
            }
        }

        public void addEntry(Entry entry, bool edit)
        {
            Entry newEntry = entry;
            int idNum;
            if (File.Exists(fileName))
            {
                string fileJsonString = File.ReadAllText(fileName);
                File.Delete(fileName);
                Entries.Clear();
                Entries = JsonSerializer.Deserialize<List<Entry>>(fileJsonString);
                // If we are adding an edited entry, we do not need to assign an Id
                if (!edit && Int32.TryParse(Entries.ElementAt<Entry>(Entries.Count - 1).Id, out int lastId))
                {
                    idNum = lastId + 1;
                    newEntry.Id = idNum.ToString();
                }

            }
            else
            {
                newEntry.Id = "1";
            }
            if (edit)
            {
                // Insert edited entry back into correct spot in list
                if (Int32.TryParse(newEntry.Id, out int entryId))
                {
                    Entries.Insert(entryId - 1, newEntry);
                }

            }
            else
            {
                Entries.Add(newEntry);
            }
            string newJsonString = JsonSerializer.Serialize(Entries);
            File.AppendAllText(fileName, newJsonString);
        }

        public bool removeEntry(int id)
        {
            if (File.Exists(fileName))
            {
                string fileJsonString = File.ReadAllText(fileName);
                Entries.Clear();
                Entries = JsonSerializer.Deserialize<List<Entry>>(fileJsonString);
                if (id > Entries.Count)
                {
                    return false;
                }
                else
                {
                    Entries.RemoveAt(id - 1);
                    File.Delete(fileName);
                    string newJsonString = JsonSerializer.Serialize(Entries);
                    File.AppendAllText(fileName, newJsonString);
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
