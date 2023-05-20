using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace View
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page, INotifyPropertyChanged
    {
        private int sizeSliderValue;
        public int SizeSliderValue
         {
            get { return sizeSliderValue; }
            set
            {
                if (sizeSliderValue != value)
                {
                    sizeSliderValue = value;
                    OnPropertyChanged("SizeSliderValue");
                }
            }
        }

        private double probablitySliderValue;
        public double ProbablitySliderValue
        {
            get { return probablitySliderValue; }
            set
            {
                if (probablitySliderValue != value)
                {
                    probablitySliderValue = value;
                    OnPropertyChanged("ProbablitySliderValue");
                }
            }
        }


        private GameViewModel gameViewModel;
        public SettingsPage()
        {
            
            InitializeComponent();
            gameViewModel = new GameViewModel(5, 0.1, true);
            DataContext = new SettingsViewModel(gameViewModel);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool isFloodingEnabled = (bool)EnableFloodingCheckBox.IsChecked;
            this.NavigationService.Navigate(new Page1(SizeSliderValue, isFloodingEnabled, ProbablitySliderValue));
        }

        private void SizeSliderValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = (Slider)sender;
            SizeSliderValue = (int)Math.Round(slider.Value);
        }

        private void ProbablitySliderValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = (Slider)sender;
            ProbablitySliderValue = Math.Round(slider.Value, 2);
        }

        public class SettingsViewModel
        {
            private GameViewModel gameViewModel;

            public int MinimumBoardSize => gameViewModel.MinimumBoardSize;
            public int MaximumBoardSize => gameViewModel.MaximumBoardSize;

            public SettingsViewModel(GameViewModel gameViewModel)
            {
                this.gameViewModel = gameViewModel;
            }
        }
    }
}