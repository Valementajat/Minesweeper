using Cells;
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
        private readonly ICell<IGameBoard> GameBoard;
       
        public IEnumerable<RowViewModel> Rows { get; }

        public GameBoardViewModel(ICell<IGame> game)
        {

            this.GameBoard = game.Derive(g => g.Board);


            // Rows 
            int Height = GameBoard.Derive(g => g.Height).Value;
            List<RowViewModel> RowsList = new();

         for (int i = 0; i < Height; i++)
            {
                RowViewModel rowViewModel = new(Row(GameBoard, game, i));

                RowsList.Add(rowViewModel);
            }
            this.Rows = RowsList;

            
        }


        IEnumerable<SquareViewModel> Row(ICell<IGameBoard> board, ICell<IGame> game, int row)
        {
            int width = GameBoard.Derive(g => g.Width).Value;
            var RowList = new List<SquareViewModel>(width);

            for (int i = 0; i < width; i++)
            {
                var position = new Vector2D(i, row);
                RowList.Add(new SquareViewModel(game, position));
            }

            return RowList;

        }

    }
}
