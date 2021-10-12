using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3;
namespace Lab4Tester
{
    [TestClass]
    public class UnitTest1
    {
        BusinessLogic bl = new BusinessLogic();
        [TestMethod]
        public void addValidEntry()
        {
            string[] validEntry = new string[] { "American Truck Brand", "Ford", "1", "10/12/2021" };
            bl.AddEntry(validEntry);
        }

        public void addInvalidEntry()
        { 
            string[] invalidEntry = new string[] { "This one is tough", "Not Possible", "50", "10/12/2021" };
            bl.AddEntry(invalidEntry);
        }

        public void validEntryEdit()
        { 
            
        }

        public void invalidEntryEdit()
        { 
            
        }

        public void deleteEntry()
        {
            bl.RemoveEntry("1");
        }

        public void listAllEntries()
        {

        }
    }
}
