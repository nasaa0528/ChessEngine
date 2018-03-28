using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class UciInt
    {
        public void PrintCommand(string comm)
        {
            Console.WriteLine(comm);
        }
        public string Check(string comm)
        {
            comm = comm.ToLower();
            if (comm.StartsWith("uci") || comm.StartsWith("debug") || comm.StartsWith("isready") || comm.StartsWith("setoption") || comm.StartsWith("register") || comm.StartsWith("ucinewgame") || comm.StartsWith("position") || comm.StartsWith("go") || comm.StartsWith("stop") || comm.StartsWith("ponderhit") || comm.StartsWith("quit"))
            {
                return comm;
            }
            else
            {
                //disabled it for check purpose 
                //comm = ""; 
                return comm;
            }
        }
        public int FRtoArr(string fr)
        {
            char file = fr[0];
            int rank = (int)Char.GetNumericValue(fr[1]);
            int result = 0;
            switch (file)
            {
                case 'a':
                    {
                        result = rank - 1;
                        break;
                    }
                case 'b':
                    {
                        result = 7 + rank;
                        break;
                    }
                case 'c':
                    {
                        result = 15 + rank;
                        break;
                    }
                case 'd':
                    {
                        result = 23 + rank;
                        break;
                    }
                case 'e':
                    {
                        result = 31 + rank;
                        break;
                    }
                case 'f':
                    {
                        result = 39 + rank;
                        break;
                    }
                case 'g':
                    {
                        result = 47 + rank;
                        break;
                    }
                case 'h':
                    {
                        result = 55 + rank;
                        break;
                    }
                default:
                    {
                        result = -1;
                        break;
                    }
            }
            return result;
        }

        public String ArrtoFR(int ind)
        {
            int rem, div;
            string result;
            div = ind / 8;
            rem = ind % 8;
            switch (div)
            {
                case 0:
                    {
                        result = "a";
                        break;
                    }
                case 1:
                    {
                        result = "b";
                        break;
                    }
                case 2:
                    {
                        result = "c";
                        break;
                    }
                case 3:
                    {
                        result = "d";
                        break;
                    }
                case 4:
                    {
                        result = "e";
                        break;
                    }
                case 5:
                    {
                        result = "f";
                        break;
                    }
                case 6:
                    {
                        result = "g";
                        break;
                    }
                case 7:
                    {
                        result = "h";
                        break;
                    }
                default:
                    {
                        result = null;
                        break;
                    }

            }
            rem += 1;
            result = result + rem.ToString();
            return result;
        }
        public void FENtoArr(string notation)
        {
            // here is the FEN format to array format
        }
    }
}
