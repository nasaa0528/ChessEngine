using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ChessEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            // depending on the command that come through uci, we are going to decide use default constructor or not 
            Board b1 = new Board();
            UciInt test = new UciInt();
            Console.WriteLine(test.ArrtoFR(45));
            Console.ReadLine();
            // b1.PrintInitValues();
        }
    }
}
