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
        public IGame game;
        public Vector2D Position;
        public UncoverSquareCommand(IGame game, Vector2D position)
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
            Debug.WriteLine(Position);
        }
    }
}
