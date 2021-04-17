using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Access_to_Database.Entities
{
    class Events
    {
        public string EventName{ set;get;}
        public string EventStory { set; get; }
        public string EventDate{ set; get; }
        public string Importance { set; get; }
        public string UserName { set; get; }
    }
}
