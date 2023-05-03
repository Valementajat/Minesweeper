using Model.Data;
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
        public IEnumerable<SquareViewModel> Squares { get; }
        
        public RowViewModel(IEnumerable<SquareViewModel> Squares, IGame Board, int rowIndex)
        {
           
            this.Squares = Squares;
          
          
        }

    }
}

