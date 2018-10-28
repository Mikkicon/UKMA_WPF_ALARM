using System.Collections.Generic;
using System.Windows.Input;
using System.Windows.Controls;
using KMA.APZRPMJ2018.WalletSimulator.Models;
using KMA.APZRPMJ2018.WalletSimulator.ViewModels;
using KMA.APZRPMJ2018.WalletSimulator.Views.Wallet;
using System.Windows;
using System;
using System.Timers;
using System.Media;

namespace KMA.APZRPMJ2018.WalletSimulator.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView
    {
        SoundPlayer p;
        DateTime current;
        private MainViewViewModel _mainWindowViewModel;
        private System.Timers.Timer _timer;
        //private WalletConfigurationView _currentWalletConfigurationView;
        //fdsadsfas
        private AlarmConfigurationViewModel _alarmConfigView;
        private ICommand _add;
        //private List<int> Hours = _alarmConfigView.Alarms[0].Hours;
        public MainView()
        {
            InitializeComponent();
            _alarmConfigView = new AlarmConfigurationViewModel();
            DataContext = _alarmConfigView;
        }

        private void Initialize()
        {

            //Visibility = Visibility.Visible;
            //_mainWindowViewModel = new MainViewViewModel();
            //_mainWindowViewModel.WalletChanged+= OnWalletChanged;
            //DataContext = _alarmView;
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            _alarmConfigView.Add();
            DataContext = _alarmConfigView;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _alarmConfigView.Delete();
            DataContext = _alarmConfigView;
            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, System.Windows.RoutedEventArgs e)
        {
           
            _timer = new System.Timers.Timer();
            _timer.Enabled = true;
            _timer.Interval = 1000;
            _timer.Start();
            _timer.Elapsed += Timer_Elapsed;
           }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {


            current = DateTime.Now;
            p = new SoundPlayer();
            p.SoundLocation = @"C:\Windows\media\Alarm01.wav";
            if (current.Hour == _alarmConfigView.SelectedAlarm.ComboHour && current.Minute == _alarmConfigView.SelectedAlarm.ComboMinute && current.Second == _alarmConfigView.SelectedAlarm.ComboSecond)
            {
               p.PlayLooping();
            }
        }

        private void ComboHours_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show((e.AddedItems[0] as ComboBoxItem).Content as string);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
            p.Stop();
            _timer.Enabled = false;
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
