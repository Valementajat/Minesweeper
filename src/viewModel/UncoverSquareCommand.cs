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

    class UncoverSquareCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public ICell<IGame> game { get; }
        public Vector2D Position;

        public UncoverSquareCommand(ICell<IGame> game, Vector2D position)
        {
            this.Position = position;
            this.game = game;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           

            var Square = game.Derive(g => g.Board[Position]).Value;
            var squareStatus = Square.Status;

            int Height = game.Derive(g => g.Board.Height).Value;

            var gameStatus = game.Derive(g => g.Status).Value;

            if (gameStatus == GameStatus.InProgress) { 
                if (squareStatus == SquareStatus.Uncovered || squareStatus == SquareStatus.Flagged)
                {
                    return;
                } else
                {
                    game.Value = game.Value.UncoverSquare(Position);
             
                }
            } else 
            {
                return;
            }
        }
    }
}
