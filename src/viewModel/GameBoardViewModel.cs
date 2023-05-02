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
    public class GameBoardViewModel
    {
        private readonly IGameBoard Board;

        public GameBoardViewModel(IGameBoard Board)
        {
            this.Board = Board;
        }

        public IEnumerable<RowViewModel> Rows
        {
            get
            {
                int Height = Board.Height;
                List<RowViewModel> RowsList = new();

                for (int i = 0; i < Height; i++)
                {
                    var rowViewModel = new RowViewModel(Row(Board, i));
                  
                    RowsList.Add(rowViewModel);
                }
                return RowsList;
            }
        }


        IEnumerable<SquareViewModel> Row(IGameBoard board, int row)
        {
            int width = board.Width;
            var RowList = new List<SquareViewModel>(width);

            for (int i = 0; i < width; i++)
            {
                var postition = new Vector2D(i, row);
                var value = board[postition];
                RowList.Add(new SquareViewModel { Square = value });
            }

            return RowList;

        }

    }
}
