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
        double probability;

        public Page1(int boardSize, bool flooding, double probability)
        {
            this.boardSize = boardSize;
            this.flooding = flooding;
            this.probability = probability;

            InitializeComponent();
            
            /*var game = IGame.Parse(new List<string> {
              "...*.",
              ".*.*.",
              ".....",
              "...*.",
              "**...",
            });*/
            this.DataContext = new GameViewModel(boardSize, probability, flooding);

        }

       

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {

            InitializeComponent();
            var GameViewModel = new GameViewModel(boardSize, probability, flooding);

            this.DataContext = GameViewModel;

        }
    
           private void button_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SettingsPage());
        }
    }
}
