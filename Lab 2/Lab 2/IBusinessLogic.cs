namespace Lab_2
{
    interface IBusinessLogic
    {
        string AddEntry(string[] entry, bool edit = false);
        bool EditEntry(string id);
        string GetCurrentEntries();
        string RemoveEntry(string id);
    }
}