using Intrahealth.Common.IHProfBL.Interop;
using System.Windows;

namespace ProfileWpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel MainVM { get; set; }
        public bool IsCapturing { get; private set; }

        private ISProfile _profile;

        public MainWindow(ISProfile profile)
        {
            InitializeComponent();
            MainVM = new MainViewModel();
            DataContext = MainVM;
            _profile = profile;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_profile != null)
            {
                _profile.CallMacro("TestFromWPF");
            }
        }

        public void SetPatient(ISPatient p)
        {
            MainVM.Patient = p;

            ISAppointmentFilter flt = _profile.CreateAppointmentFilter();
            flt.PatientId = p.ID;
            MainVM.Appointments = _profile.LoadAppointments(flt);
        }
    }
}
