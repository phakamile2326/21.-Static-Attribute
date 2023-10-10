using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Static_Attribute
{
    internal class Program

    {
        static void Main(string[] args) 
        {
            Songs holiday = new Songs("Holiday", "green day", 2);
            Songs preach = new Songs("preach","John Legend", 5);
            Console.WriteLine(Songs.songCount);
            Console.ReadLine();        
        
        
        } 

    }
}
