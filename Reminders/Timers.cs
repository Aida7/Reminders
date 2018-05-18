using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Reminders
{
    public class Timers 
    {
        public int Id { get; set; }
        public DispatcherTimer timer { get; set; }
        public int Hour { get; set; }
        public int Min { get; set; }
        public int Sec { get; set; }
        public DateTime Time { get; set; }
    }
    
}
