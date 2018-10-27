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
            //string textValue =listBox.ComboHours.ToString();
            //string s = _alarmConfigView.SelectedAlarm._hour.ToString() + _alarmConfigView.SelectedAlarm._minute.ToString() + _alarmConfigView.SelectedAlarm._second.ToString();
            //Alarm text =(Alarm) listBox.SelectedItem;
            //MessageBox.Show(System.DateTime.Now.ToString(),"Now is:");
            //MessageBox.Show(_alarmConfigView.SelectedAlarm.);
            //MessageBox.Show(s);
            _timer = new System.Timers.Timer();
            SoundPlayer p = new SoundPlayer();
            p.SoundLocation = @"C:\Windows\media\Alarm01.wav";
            p.PlayLooping();
            //_timer.Interval = 1000;
            //_timer.Elapsed += Timer_Elapsed;
            //MessageBox.Show(_alarmConfigView.SelectedAlarm.Hours.ToString()+ _alarmConfigView.SelectedAlarm.Minutes.ToString()+ _alarmConfigView.SelectedAlarm.Seconds.ToString());
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime current = DateTime.Now;
            SoundPlayer p = new SoundPlayer();
            p.SoundLocation = @"C:\Windows\media\Alarm01.wav";
            p.PlayLooping();
        }

        private void ComboHours_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show((e.AddedItems[0] as ComboBoxItem).Content as string);
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
