using Cells;
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
        public ICell<Square> Square { get; set; }
        public ICommand Uncover { get; }

       

        public SquareViewModel(ICell<IGame> game, Vector2D position)
        {
            this.Square = game.Derive(g => g.Board[position]);
          
            this.Uncover = new UncoverSquareCommand(game, position);
            
        }
    }
}
