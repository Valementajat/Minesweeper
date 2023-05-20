using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace viewModel
{
    public class GameViewModel
    {
        
        public GameBoardViewModel Board { get; }
        public int MinimumBoardSize { get; }
        public int MaximumBoardSize { get; }

        public GameViewModel(int boardSize, double probability, bool flooding)
        {
            var game = IGame.CreateRandom(boardSize, probability, flooding);
            /*var game = IGame.Parse(new List<string> {
              "...*.",
              ".*.*.",
              ".....",
              "...*.",
              "**...",
            });*/
            ICell<IGame> currentGame = Cell.Create(game);
            
            this.Board = new GameBoardViewModel(currentGame, flooding, probability);
            this.MinimumBoardSize = IGame.MinimumBoardSize;
            this.MaximumBoardSize = IGame.MaximumBoardSize;
        }

       
    }
}
