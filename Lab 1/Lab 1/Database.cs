using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab_1
{
    class Database
    {
        string fileName = "database.json";

        public String getAllEntries() 
        {
            return File.ReadAllText(fileName);
        }
    }
}
