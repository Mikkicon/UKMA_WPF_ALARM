using Alarm_Petrenko_Riepkin.Tools;
using System.Windows.Controls;
using Alarm_Petrenko_Riepkin.Managers;

namespace Alarm_Petrenko_Riepkin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : IContentWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var navigationModel = new NavigationModel(this);
            NavigationManager.Instance.Initialize(navigationModel);
            navigationModel.Navigate(EnumModes.AlarmMain);
        }

        public ContentControl ContentControl
        {
            get { return _contentControl; }
        }
    }
}
