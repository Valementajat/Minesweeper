using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viewModel
{
    public class RowViewModel
    {
        public IEnumerable<Square> Squares { get ; set; }

        public RowViewModel()
        {
           

        }

    }
}
