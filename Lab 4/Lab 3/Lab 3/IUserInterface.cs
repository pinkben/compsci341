namespace Lab_3
{
    public interface IUserInterface
    {
        string AddEntry(string[] entry);
        string DeleteEntry(string response);
        string EditEntry(string[] response);
        string ListEntries();
    }
}