using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Lab_4
{
    class Database : IDatabase
    {
        string fileName = "Database.json";
        List<Entry> Entries = new List<Entry>();

        public List<Entry> GetAllEntries()
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

        public Entry GetEntry(int id)
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
            };
        }

        public void AddEntry(Entry entry, bool edit)
        {
            string connectionStringToDB = ConfigurationManager.ConnectionStrings["new connection"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(connectionStringToDB);
            sqlConnection.Open();
            Entry newEntry = entry;
            int idNum;

            if (File.Exists(fileName))
            {
                string fileJsonString = File.ReadAllText(fileName);

                File.Delete(fileName);
                Entries.Clear();
                Entries = JsonSerializer.Deserialize<List<Entry>>(fileJsonString);
                // If we are adding an edited entry, we do not need to assign an Id
                if (Entries.Count != 0)
                {
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
                    MySqlCommand deleteCmd = new MySqlCommand("DELETE FROM CrosswordEntry WHERE id = @id;", sqlConnection);
                    deleteCmd.Parameters.Add(new MySqlParameter("id", entryId));
                    MySqlDataReader reader = deleteCmd.ExecuteReader();
                    MySqlCommand insertCmd = new MySqlCommand("INSERT INTO CrosswordEntry(id, clue, answer, difficulty, date) " +
                        "VALUE(@id, @clue, @answer, @difficulty, @date);", sqlConnection);
                    insertCmd.Parameters.Add(new MySqlParameter("id", entryId));
                    insertCmd.Parameters.Add(new MySqlParameter("clue", newEntry.Clue));
                    insertCmd.Parameters.Add(new MySqlParameter("answer", newEntry.Answer));
                    insertCmd.Parameters.Add(new MySqlParameter("difficulty", newEntry.Difficulty));
                    insertCmd.Parameters.Add(new MySqlParameter("date", newEntry.Date));
                    MySqlDataReader reader1 = insertCmd.ExecuteReader();
                }
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO CrosswordEntry(clue, answer, difficulty, date) " +
                    "VALUE(@clue, @answer, @difficulty, @date);", sqlConnection);
                cmd.Parameters.Add(new MySqlParameter("clue", newEntry.Clue));
                cmd.Parameters.Add(new MySqlParameter("answer", newEntry.Answer));
                cmd.Parameters.Add(new MySqlParameter("difficulty", newEntry.Difficulty));
                cmd.Parameters.Add(new MySqlParameter("date", newEntry.Date));
                MySqlDataReader reader = cmd.ExecuteReader();
                Entries.Add(newEntry);
            }
            string newJsonString = JsonSerializer.Serialize(Entries);
            File.AppendAllText(fileName, newJsonString);
            sqlConnection.Close();
        }

        public bool RemoveEntry(int id)
        {
            bool found = false;
            string connectionStringToDB = ConfigurationManager.ConnectionStrings["new connection"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(connectionStringToDB);
            sqlConnection.Open();
            if (File.Exists(fileName))
            {
                //MySqlCommand deleteCmd = new MySqlCommand("DELETE FROM CrosswordEntry WHERE id = @id;", sqlConnection);
                //deleteCmd.Parameters.Add(new MySqlParameter("id", id));
                //MySqlDataReader reader = deleteCmd.ExecuteReader();
                string fileJsonString = File.ReadAllText(fileName);
                Entries.Clear();
                Entries = JsonSerializer.Deserialize<List<Entry>>(fileJsonString);
                foreach (Entry entry in Entries)
                {
                    int temp = Int32.Parse(entry.Id);
                    if (temp == id)
                    {
                        Entries.Remove(entry);
                        File.Delete(fileName);
                        string newJsonString = JsonSerializer.Serialize(Entries);
                        File.AppendAllText(fileName, newJsonString);
                        found = true;
                        break;
                    }
                }
                sqlConnection.Close();
                return found;
            }
            else
            {
                sqlConnection.Close();
                return false;
            }
        }
    }
}
