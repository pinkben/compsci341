using System.Collections.Generic;

namespace Lab_3
{
    interface IDatabase
    {
        void AddEntry(Entry entry, bool edit);
        List<Entry> GetAllEntries();
        Entry GetEntry(int id);
        bool RemoveEntry(int id);
    }
}