using Digital_Diary.Access_to_Database;
using Digital_Diary.Access_to_Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Codes
{
    class EventsServices
    {
        EventsDataAccess eventsDataAccess;

        public EventsServices()
        {
            this.eventsDataAccess = new EventsDataAccess();
        }

        public int AddEvents(string eventName,string story,string eventDate,string importance,string userName)
        {
            Events events = new Events()
            {
                EventName = eventName,
                EventStory = story,
                EventDate = eventDate,
                Importance = importance,
                UserName = userName,
            };
            this.eventsDataAccess = new EventsDataAccess();
            return this.eventsDataAccess.AddEvents(events);
        }
        public int AddPictures(string picture,string eventname)
        {
            EventPictures eventPictures = new EventPictures()
            {
                Pictures = picture,
                EventsName = eventname
            };
            this.eventsDataAccess = new EventsDataAccess();
            return this.eventsDataAccess.AddingPictures(eventPictures);
        }

        public bool CheckingEventName(string eventName)
        {
            Events events = new Events();
            this.eventsDataAccess = new EventsDataAccess();
            events = this.eventsDataAccess.EventNameCheck(eventName);

            if (events == null) return false;
            if (events.EventName == eventName)
            {
                return true;
            }
            else return false;
        }
    }
}
