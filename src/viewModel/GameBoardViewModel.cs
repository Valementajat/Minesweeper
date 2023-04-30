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

        public IEnumerable<IEnumerable<Square>> Rows
        {
            get
            {

                int Height = Board.Height;
                Debug.WriteLine(Height, "töis mutten duunis");
                List<List<Square>> RowsList = new() { };

                for (int i = 0; i < Height; i++)
                {
                    var RowList = new List<Square>();
                    RowList.AddRange(Row(Board, i));
                    RowsList.Add(RowList);
                }
                return RowsList;
            }
        }

        IEnumerable<Square> Row(IGameBoard board, int row)
        {
            int width = board.Width;
            var RowList = new List<Square>(width);

            for (int i = 0; i < width; i++)
            {
                var postition = new Vector2D(i, row);
                var value = board[postition];
                RowList.Add(value);
            }

            return RowList;

        }

    }
}
