using System.Collections.ObjectModel;
using System.ComponentModel;
using Intrahealth.Common.IHProfBL.Interop;

namespace ProfileWpfApp1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> Items { get; set; }
        private ISPatient _patient;
        public ObservableCollection<ISAppointment> ObsAppointments { get; set; }

        private ISAppointments _appointments;

        public ISAppointments Appointments
        {
            get { return _appointments; }
            set
            {
                this._appointments = value;
                ObsAppointments.Clear();
                for(int i=0; i< _appointments.Count; i++)
                {
                    ObsAppointments.Add(_appointments[i]);
                }
                OnPropertyChanged("Appointments");
            }
        }

        public ISPatient Patient
        {
            get { return _patient; }
            set
            {
                if (value != this._patient)
                {
                    this._patient = value;
                    OnPropertyChanged("Patient");
                }
            }
        }

        public MainViewModel()
        {
            Items = new ObservableCollection<string>
            {
                "Created by VM"
            };
            ObsAppointments = new ObservableCollection<ISAppointment>();

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName = null)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
