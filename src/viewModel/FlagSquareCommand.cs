using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace viewModel
{
    class FlagSquareCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public ICell<IGame> game;
        public Vector2D Position;

        public FlagSquareCommand(ICell<IGame> game, Vector2D position)
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

            var gameStatus = game.Derive(g => g.Status).Value;

            if (gameStatus == GameStatus.InProgress)
            {
                if (squareStatus == SquareStatus.Covered)
                {
                    game.Value = game.Value.ToggleFlag(Position);
                }
                else if (squareStatus == SquareStatus.Flagged)
                {
                    game.Value = game.Value.ToggleFlag(Position);
                }
            }
            else
            {
                return;
            }
        }
    }
}
