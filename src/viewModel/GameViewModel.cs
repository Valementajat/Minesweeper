using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace viewModel
{
    public class GameViewModel
    {
        private readonly IGame _game;
        public GameBoardViewModel Board { get; }

        public GameViewModel(IGame game)
        {
            _game = game;
            this.Board = new GameBoardViewModel(game);
        }

       
    }
}
