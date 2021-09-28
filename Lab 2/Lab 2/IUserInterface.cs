namespace Lab_2
{
    public interface IUserInterface
    {
        void AddEntry(string[] entry);
        void DeleteEntry(string response);
        void EditEntry();
        string ListEntries();
    }
}