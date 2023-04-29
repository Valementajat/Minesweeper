using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace view
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           

            var game = IGame.Parse(new List<string> {
              "...*.",
              ".*.*.",
              ".....",
              "...*.",
              "**...",
            });

            var position = new Vector2D(2, 1);
            game = game.UncoverSquare(position);
            position = new Vector2D(0, 0);
            game = game.ToggleFlag(position);
            position = new Vector2D(3, 0);
            game = game.UncoverSquare(position);
            

            var board = game.Board;

            var board1 = Rows(board);

          

            this.boardView.ItemsSource = board1;
            // var game = IGame.CreateRandom(10, 0.1);





            IEnumerable<Square> Row(IGameBoard board, int row)
            {
                int width = board.Width;
                var RowList = new List<Square>(width);

                for (int i = 0; i < width; i++) { 
                    var postition = new Vector2D(i, row);
                    var value = board[postition];
                    RowList.Add(value);
                }
            
                return RowList;

            }

            IEnumerable<IEnumerable<Square>> Rows(IGameBoard board)
            {
                int Height = board.Height;
                List<List<Square>> RowsList = new() { };
               
                for (int i = 0; i < Height; i++)
                {
                   var RowList = new List<Square>();
                   RowList.AddRange(Row(board, i));
                   RowsList.Add(RowList);
                }
                return RowsList;
            }
        }

    }

}
