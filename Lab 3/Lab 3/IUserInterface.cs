namespace Lab_3
{
    public interface IUserInterface
    {
        string AddEntry(string[] entry);
        string DeleteEntry(string response);
        void EditEntry(string[] response);
        string ListEntries();
    }
}