using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viewModel
{
    public class RowViewModel
    {
        public IEnumerable<SquareViewModel> Squares { get ; set; }
        private readonly IGame Board;
        public RowViewModel(IEnumerable<SquareViewModel> Squares, IGame Board)
        {
            this.Squares = Squares;
            new SquareViewModel { Board = Board };
        }

    }
}
