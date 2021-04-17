using Digital_Diary.Access_to_Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Access_to_Database
{
    class EventsDataAccess:DataAccess
    {
        public int AddEvents(Events events)
        {
            string sql = "INSERT INTO Events(EventName,Story,EventDate,Importance,UserName) VALUES('" + events.EventName + "','" + events.EventStory + "','" + events.EventDate + "','" + events.Importance + "','" + events.UserName + "')";
            return this.ExecuteQuery(sql);
        }

        public int AddingPictures(EventPictures eventPictures)
        {
            string sql = "INSERT INTO Pictures(Pictures,EventName) VALUES('" + eventPictures.Pictures + "','" + eventPictures.EventsName + "')";
            return this.ExecuteQuery(sql);
        }
    }
}
