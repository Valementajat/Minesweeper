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
using viewModel;

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

            var game = IGame.CreateRandom(10, 0.1);
            /*var game = IGame.Parse(new List<string> {
              "...*.",
              ".*.*.",
              ".....",
              "...*.",
              "**...",
            });*/
          
            var GameViewModel = new GameViewModel(game);

            this.DataContext = GameViewModel;

        }

        

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
           
            InitializeComponent();

            var game = IGame.CreateRandom(10, 0.1);
            /*var game = IGame.Parse(new List<string> {
              "...*.",
              ".*.*.",
              ".....",
              "...*.",
              "**...",
            });*/

            var GameViewModel = new GameViewModel(game);

            this.DataContext = GameViewModel;
        }
    }

}
