using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace viewModel
{
    public class SquareViewModel
    {
        public Square Square { get; set; }
        public ICommand Uncover { get; }

       

        public SquareViewModel(IGame Board, Vector2D position)
        {
            this.Square = Board.Board[position];
            this.Uncover = new UncoverSquareCommand(Board, position);
        }
    }
}
