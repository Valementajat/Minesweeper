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
        internal int size;
        internal bool flooding;
        internal double probability;

        public UncoverSquareCommand(ICell<IGame> game, Vector2D position, bool flooding, double probability)
        {
            this.Position = position;
            this.game = game;

            this.flooding = flooding;
            this.size = game.Derive(g => g.Board.Height).Value;
            this.probability = probability;



        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            bool whileTrue = true;
            while (whileTrue) { 
                var Square = game.Derive(g => g.Board[Position]).Value;
                
                var squareStatus = Square.Status;
                var gameStatus = game.Derive(g => g.Status).Value;
                if (gameStatus == GameStatus.InProgress)
                {
                    if (squareStatus == SquareStatus.Uncovered || squareStatus == SquareStatus.Flagged)
                    {
                        return;
                    }
                    else
                    {
                        if (checkForCoveredSquares())
                        {

                            IGame checkGame = game.Value.UncoverSquare(Position);
                            var status = checkGame.Status;
                            if (status == GameStatus.Lost)
                            {

                                game.Value = IGame.CreateRandom(size, probability, flooding);

                            } else
                            {
                                game.Value = game.Value.UncoverSquare(Position);
                                whileTrue = false;
                            }

                        } else
                        {
                            game.Value = game.Value.UncoverSquare(Position);
                            whileTrue = false;
                        }
                    }

                }
            }

        }
        internal bool checkForCoveredSquares()
        {
            bool allSquaresCovered = true;


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var squarePosition = new Vector2D(i, j);
                    if (!game.Value.IsSquareCovered(squarePosition))
                    {
                        allSquaresCovered = false;
                        break;

                    }
                }
                if (!allSquaresCovered)
                {
                    break;
                }

            }

            return allSquaresCovered;

        }

    }
}
