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

        public RowViewModel(IEnumerable<SquareViewModel> Squares)
        {
            this.Squares = Squares;

        }

    }
}
