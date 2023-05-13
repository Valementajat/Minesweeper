using Model.MineSweeper;
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

namespace View
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page, INotifyPropertyChanged
    {
        private int sliderValue;
        public int SliderValue
        {
            get { return sliderValue; }
            set
            {
                if (sliderValue != value)
                {
                    sliderValue = value;
                    OnPropertyChanged("SliderValue");
                }
            }
        }

        public SettingsPage()
        {
            InitializeComponent();
            DataContext = new SettingsViewModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool isFloodingEnabled = (bool)EnableFloodingCheckBox.IsChecked;
            this.NavigationService.Navigate(new Page1(SliderValue, isFloodingEnabled));
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = (Slider)sender;
            SliderValue = (int)Math.Round(slider.Value);
        }

        public class SettingsViewModel
        {
            public int MinimumBoardSize { get; } = IGame.MinimumBoardSize;
            public int MaximumBoardSize { get; } = IGame.MaximumBoardSize;
        }
    }
}