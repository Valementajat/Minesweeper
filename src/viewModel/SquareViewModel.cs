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

        public IGame Board;
        public SquareViewModel()
        {

            Uncover = new UncoverSquareCommand( Board);
        }
    }
}
