using System.Collections.Generic;

namespace Lab_4
{
    interface IDatabase
    {
        void AddEntry(Entry entry, bool edit);
        List<Entry> GetAllEntries();
        Entry GetEntry(int id);
        bool RemoveEntry(int id);
    }
}