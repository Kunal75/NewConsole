using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewConsole
{
    class Program
    {
        private static void Main()
        {
            var friendList = new List<string> {"kunal", "Sonali", "Varun", "Aadesh"};
            friendList.ForEach(Console.WriteLine);
            Console.ReadKey(true);
        }
    }
}
