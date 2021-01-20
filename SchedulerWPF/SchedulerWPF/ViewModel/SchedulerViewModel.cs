using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media;

namespace WpfScheduler
{
    public class SchedulerViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Meeting> meetings;
        public event PropertyChangedEventHandler PropertyChanged;
        public SchedulerViewModel()
        {
            this.Meetings = new ObservableCollection<Meeting>();
            this.AddAppointments();

        }
        public ObservableCollection<Meeting> Meetings
        {
            get
            {
                return this.meetings;
            }
            set
            {
                this.meetings = value;
                this.RaiseOnPropertyChanged("Meetings");
            }
        }
        private void AddAppointments()
        {
            var meeting = new Meeting();
            meeting.EventName = "Client Meeting";
            meeting.From = new DateTime(2020, 12, 13, 10, 0, 0);
            meeting.To = meeting.From.AddHours(2);
            meeting.BackgroundColor = new SolidColorBrush(Colors.Gray);
            meeting.ForegroundColor = new SolidColorBrush(Colors.White);
            meeting.RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=10";
            this.Meetings.Add(meeting);
        }
        private void RaiseOnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
    

