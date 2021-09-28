using System.Collections.Generic;

namespace Lab_2
{
    interface IDatabase
    {
        void AddEntry(Entry entry, bool edit);
        List<Entry> GetAllEntries();
        Entry GetEntry(int id);
        bool RemoveEntry(int id);
    }
}