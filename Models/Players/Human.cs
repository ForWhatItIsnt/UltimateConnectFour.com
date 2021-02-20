﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connect4_Web_Project.Models.Players
{
    public class Human : Player
    {
        public string Name { get; set; }

        public override int MakeMove(int[,] grid)
        {
            Console.WriteLine("Pick Column to Place Piece");
            bool success = int.TryParse(Console.ReadLine(), out int col);
            //Loop to keep the input going?

            if (col - 1 < 0)
            {
                col = 0;
                return col;
            }
            return col - 1;
        }
    }
}