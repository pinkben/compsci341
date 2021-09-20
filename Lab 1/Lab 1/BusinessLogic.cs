using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class BusinessLogic
    {
        public bool checkMenuSelection(String selection)
        {
            if (selection.Equals("1") || selection.Equals("2") || selection.Equals("3") ||
                selection.Equals("4") || selection.Equals("5"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
