using Syncfusion.Windows.Shared;
using System;
using System.Windows.Media;

namespace WpfScheduler
{
    public class Meeting
    {
        public string EventName { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Brush BackgroundColor { get; set; }
        public Brush ForegroundColor { get; set; }
        public string RecurrenceRule { get; set; }
    }
}








