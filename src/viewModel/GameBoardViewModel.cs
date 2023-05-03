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
        private readonly IGameBoard GameBoard;
       
        public IEnumerable<RowViewModel> Rows { get; }

        public GameBoardViewModel(IGame Board)
        {

            this.GameBoard = Board.Board;


            // Rows 
            int Height = GameBoard.Height;
            List<RowViewModel> RowsList = new();

            for (int i = 0; i < Height; i++)
            {
                RowViewModel rowViewModel = new(Row(GameBoard,Board, i));

                RowsList.Add(rowViewModel);
            }
            this.Rows = RowsList;


        }


        IEnumerable<SquareViewModel> Row(IGameBoard board, IGame Board, int row)
        {
            int width = board.Width;
            var RowList = new List<SquareViewModel>(width);

            for (int i = 0; i < width; i++)
            {
                var position = new Vector2D(i, row);
                
                var value = board[position];
                RowList.Add(new SquareViewModel(Board, position));
            }

            return RowList;

        }

    }
}
