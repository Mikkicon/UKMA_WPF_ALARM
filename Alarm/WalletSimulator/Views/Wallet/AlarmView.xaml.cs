using KMA.APZRPMJ2018.WalletSimulator.ViewModels;

namespace KMA.APZRPMJ2018.WalletSimulator.Views.Wallet
{
    /// <summary>
    /// Interaction logic for WalletConfigurationView.xaml
    /// </summary>
    public partial class AlarmView
    {
        public AlarmView()
        {
            InitializeComponent();
            var walletModel = new AlarmView();
            DataContext = walletModel;
        }
    }
}
