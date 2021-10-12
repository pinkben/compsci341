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
            if (edit)
            {
                // Insert edited entry back into correct spot in list
                if (Int32.TryParse(newEntry.Id, out int entryId))
                {
                    //Remove old entry
                    MySqlCommand editCmd = new MySqlCommand("UPDATE CrosswordEntry SET clue = @clue, answer = @answer, difficulty = @difficulty, " +
                        "date = @date WHERE ID = @id", sqlConnection);
                    editCmd.Parameters.Add(new MySqlParameter("id", entryId));
                    editCmd.Parameters.Add(new MySqlParameter("clue", newEntry.Clue));
                    editCmd.Parameters.Add(new MySqlParameter("answer", newEntry.Answer));
                    editCmd.Parameters.Add(new MySqlParameter("difficulty", newEntry.Difficulty));
                    editCmd.Parameters.Add(new MySqlParameter("date", newEntry.Date));
                    MySqlDataReader reader = editCmd.ExecuteReader();
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
            sqlConnection.Close();
        }

        public bool RemoveEntry(int id)
        {
            string connectionStringToDB = ConfigurationManager.ConnectionStrings["new connection"].ConnectionString;
            MySqlConnection sqlConnection = new MySqlConnection(connectionStringToDB);
            sqlConnection.Open();
            MySqlCommand deleteCmd = new MySqlCommand("DELETE FROM CrosswordEntry WHERE id = @id;", sqlConnection);
            deleteCmd.Parameters.Add(new MySqlParameter("id", id));
            int row = deleteCmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (row == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
