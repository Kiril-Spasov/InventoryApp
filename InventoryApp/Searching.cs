using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    internal class Searching
    {
        public static int LinearSearch(string[] data, string key, int upperLimit)
        {
            for (int i = 1; i <= upperLimit; i++)
            {
                if (data[i] != null)
                {
                    if (data[i] == key)
                    {
                        return i;
                    }
                }              
            }
            return -1;
        }
    }
}
