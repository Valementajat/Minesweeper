using Model.MineSweeper;
using System;
using System.Collections.Generic;
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

namespace View
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        int boardSize;
        bool flooding = false;

        public Page1(int boardSize, bool flooding)
        {
            this.boardSize = boardSize;
            this.flooding = flooding;

            InitializeComponent();
            var game = IGame.CreateRandom(boardSize, 0.1, flooding);
            /*var game = IGame.Parse(new List<string> {
              "...*.",
              ".*.*.",
              ".....",
              "...*.",
              "**...",
            });*/

            this.DataContext = new GameViewModel(game);

        }



        private void NewGame_Click(object sender, RoutedEventArgs e)
        {

            InitializeComponent();

            var game = IGame.CreateRandom(boardSize, 0.1, flooding);
            var GameViewModel = new GameViewModel(game);

            this.DataContext = GameViewModel;

        }
    
           private void button_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SettingsPage());
        }
    }
}
