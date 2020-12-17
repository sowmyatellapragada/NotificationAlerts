using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class subEventArgs : EventArgs
    {
        public Subscriber Subscriber { get; set; }
        public string publisher { get; set; }
    }
}
