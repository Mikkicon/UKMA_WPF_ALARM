using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using KMA.APZRPMJ2018.WalletSimulator.Models;
using KMA.APZRPMJ2018.WalletSimulator.Properties;

namespace KMA.APZRPMJ2018.WalletSimulator.ViewModels
{
    internal class AlarmConfigurationViewModel : INotifyPropertyChanged
    {
        #region Fields
        public List<int> Hours { get; set; }
        public Alarm _alarm;
        public List<int> Minutes { get; set; }
        private ObservableCollection<Alarm> _alarms;

        #endregion

        #region Constructor
        public AlarmConfigurationViewModel()
        {
            Initialize();
            Add();
        }
        public void Initialize()
        {
            
            Hours = new List<int>();
            Minutes = new List<int>();
            for (int i = 0; i < 24; i++)
            {
                Hours.Add(i);
            }
            for (int i = 0; i < 60; i++)
            {
                Minutes.Add(i);
            }
            FillAlarms();
        }

        private void FillAlarms()
        {
                _alarms = new ObservableCollection<Alarm>();
                
                _alarms.Add(new Alarm());
                
                
            
        }

        public ObservableCollection<Alarm> Alarms
        {
            get { return _alarms; }
        }
        public void Add()
        {
            Alarm al = new Alarm();
            _alarms.Add(al);
        }
        public void Delete()
        {
            _alarms.Remove(_alarms[0]);
        }
        #endregion
        #region EventsAndHandlers
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        internal virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #endregion


    }
}
