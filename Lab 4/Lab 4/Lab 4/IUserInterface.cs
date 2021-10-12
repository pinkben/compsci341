namespace Lab_4
{
    public interface IUserInterface
    {
        string AddEntry(string[] entry);
        string DeleteEntry(string response);
        string EditEntry(string[] response);
        string ListEntries();
    }
}