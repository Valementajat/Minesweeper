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

        public GameViewModel(IGame game)
        {
           
            this.Board = new GameBoardViewModel(game);
        }

       
    }
}
