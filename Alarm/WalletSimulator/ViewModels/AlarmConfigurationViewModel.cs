using System.Collections.Generic;
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
        public List<int> Minutes { get; set; }
        
           
            #endregion

            #region Constructor
            public AlarmConfigurationViewModel()
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
