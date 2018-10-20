using KMA.APZRPMJ2018.WalletSimulator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KMA.APZRPMJ2018.WalletSimulator.ViewModels
{
    internal class AlarmViewModel: INotifyPropertyChanged
    {
        public List<int> HoursCollection { get; set; }
        internal AlarmViewModel()
        {
            HoursCollection = new List<int>();
            for (int i = 0; i < 24; i++)
            {
                HoursCollection.Add(i);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        internal virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
