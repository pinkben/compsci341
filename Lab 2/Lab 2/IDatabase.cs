using System.Collections.Generic;

namespace Lab_1
{
    interface IDatabase
    {
        void addEntry(Entry entry, bool edit);
        List<Entry> getAllEntries();
        Entry getEntry(int id);
        bool removeEntry(int id);
    }
}