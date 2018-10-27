using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using KMA.APZRPMJ2018.WalletSimulator.Models;
using KMA.APZRPMJ2018.WalletSimulator.Properties;

namespace KMA.APZRPMJ2018.WalletSimulator.ViewModels
{
    internal class AlarmConfigurationViewModel : INotifyPropertyChanged
    {
        #region Fields
        private Alarm _selectedAlarm;
        
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
            
           
            FillAlarms();
        }
        
       
        public Alarm SelectedAlarm
        {
            get{ return _selectedAlarm; }
            set { _selectedAlarm = value; }
        }

        private void FillAlarms()
        {
                _alarms = new ObservableCollection<Alarm>();
                Alarm a = new Alarm();
            
                _alarms.Add(a);
        }

        public ObservableCollection<Alarm> Alarms
        {
            get { return _alarms; }
        }
        
        public void Add()
        {
            Alarm al = new Alarm();
            SelectedAlarm = al;
            _alarms.Add(al);
        }
        public void Delete()
        {
            _alarms.Remove(SelectedAlarm);
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
