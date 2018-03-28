using System;

namespace ChessEngine
{
    class Board
    {
        // Int 64-sized array for Board representation, and list of pieces 
        // Pieces lists are locating the index of that pieces, and if it captures, it will save 65 for the location
        public int[] bArray, wPawns, wRoots, wKnights, wBishops, bPawns, bRoots, bKnights, bBishops;
        int wQueen, wKing, bQueen, bKing;
        // Pieces on the board and ply counter for fifty moves 
        public int emp, wP, wR, wN, wB, wQ, wK, bP, bR, bN, bB, bQ, bK, plyNum;

        // enPass, fifty move, Castling permission checker 
        public bool enPass, wQC, wKC, bQC, bKC, fiftyMove, wTurn, bTurn;

        // normal starting position will get data from the default constructor. 
        public Board()
        {
            emp = 0;
            wP = 1;
            wR = 2;
            wN = 3;
            wB = 4;
            wQ = 5;
            wK = 6;
            bP = -1;
            bR = -2;
            bN = -3;
            bB = -4;
            bQ = -5;
            bK = -6;
            plyNum = 0;
            bArray = new int[64] 
            {
                wR, wN, wB, wQ, wK, wB, wN, wR,
                wP, wP, wP, wP, wP, wP, wP, wP,
                emp, emp, emp, emp, emp, emp, emp, emp,
                emp, emp, emp, emp, emp, emp, emp, emp,
                emp, emp, emp, emp, emp, emp, emp, emp,
                emp, emp, emp, emp, emp, emp, emp, emp,
                bP, bP, bP, bP, bP, bP, bP, bP,
                bR, bN, bB, bQ, bK, bB, bN, bR
                
            };

            wPawns = new int[8] { 8, 9, 10, 11, 12, 13, 14, 15 };
            wRoots = new int[2] { 0, 7 };
            wKnights = new int[2] { 1, 6 };
            wBishops = new int[2] { 2, 5 };
            wQueen = 3;
            wKing = 4; 

            bPawns = new int[8] { 48, 49, 50, 51, 52, 53, 54, 55 };
            bRoots = new int[2] { 56, 63 };
            bKnights = new int[2] { 57, 62 };
            bBishops = new int[2] { 58, 61 };
            bQueen = 59;
            bKing = 60;

            enPass = fiftyMove = bTurn = false;
            wQC = wKC = bQC = bKC = wTurn = true;            
        }

        public int IsUnderAttack()
        {
            

            //if not under the attack
            return 0;
        }



        //FOR DEBUGGING


        //public void PrintInitValues()
        //{
        //    Console.WriteLine("~~~ PIECES ~~~");
        //    Console.WriteLine("Empty on the Board: {0}", emp);
        //    Console.WriteLine("White Pices");
        //    Console.WriteLine("Pawn: {0} Rook: {1} Knight: {2} Bishop: {3} Queen: {4} King: {5}", 
        //                           wP, wR, wN, wB, wQ, wK);
        //    Console.WriteLine("Black Pices");
        //    Console.WriteLine("Pawn: {0} Rook: {1} Knight: {2} Bishop: {3} Queen: {4} King: {5}",
        //                           bP, bR, bN, bB, bQ, bK);
        //    Console.WriteLine("ply Number: {0} ", plyNum);
        //    Console.WriteLine("Castling Perm: WQ: {0} , WK: {1}, BQ: {2}, BK: {3}, enPassant: {4}, FiftyMove: {5}", 
        //                           wQC, wKC, bQC, bKC, enPass, fiftyMove);
        //    for (int i = 0; i < bArray.Length; i++)
        //    {
        //        if (i % 8 == 0)
        //        {
        //            Console.WriteLine();
        //        }
        //        Console.Write("{0,3} ", bArray[i]);
        //    }
        //}
         
    }
}
