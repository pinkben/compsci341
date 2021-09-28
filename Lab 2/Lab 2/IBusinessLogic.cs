namespace Lab_1
{
    interface IBusinessLogic
    {
        string AddEntry(string[] entry, bool edit = false);
        bool CheckMenuSelection(string selection);
        bool EditEntry(string id);
        string GetCurrentEntries();
        string RemoveEntry(string id);
    }
}