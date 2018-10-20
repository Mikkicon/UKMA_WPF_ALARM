using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using KMA.APZRPMJ2018.WalletSimulator.ViewModels;
using KMA.APZRPMJ2018.WalletSimulator.Views.Wallet;

namespace KMA.APZRPMJ2018.WalletSimulator.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView
    {
        private MainViewViewModel _mainWindowViewModel;
        //private WalletConfigurationView _currentWalletConfigurationView;
        //fdsadsfas
        private AlarmView _alarmView;
        public MainView()
        {
            InitializeComponent();
            DataContext = new AlarmConfigurationViewModel();
        }

        private void Initialize()
        {
            
            //Visibility = Visibility.Visible;
            //_mainWindowViewModel = new MainViewViewModel();
            //_mainWindowViewModel.WalletChanged+= OnWalletChanged;
            //DataContext = _alarmView;
        }
        /*
        private void OnWalletChanged(Models.Wallet wallet)
        {
            if (_currentWalletConfigurationView == null)
            {
                _currentWalletConfigurationView = new WalletConfigurationView(wallet);
                MainGrid.Children.Add(_currentWalletConfigurationView);
                Grid.SetRow(_currentWalletConfigurationView, 0);
                Grid.SetRowSpan(_currentWalletConfigurationView, 2);
                Grid.SetColumn(_currentWalletConfigurationView, 1);
            }
            else
                _currentWalletConfigurationView.DataContext = new WalletConfigurationViewModel(wallet);

        }*/
        
    }
}
