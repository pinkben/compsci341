namespace Lab_1
{
    interface IBusinessLogic
    {
        string addEntry(string[] entry, bool edit = false);
        bool checkMenuSelection(string selection);
        bool editEntry(string id);
        string getCurrentEntries();
        string removeEntry(string id);
    }
}