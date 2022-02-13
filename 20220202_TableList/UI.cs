using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace _20220202_TableList
{
    class UI
    {
        public static void ViewTable<T>(IEnumerable<T> table)
        {
            foreach (var item in table)
            {
                Console.WriteLine(item);
            }
        }
    }
}
