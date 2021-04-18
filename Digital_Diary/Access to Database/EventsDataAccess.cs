using Digital_Diary.Access_to_Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public Events EventNameCheck(string eventName)
        {
            string sql = "SELECT * FROM Events WHERE EventName='" + eventName + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                Events events = new Events();
                events.EventName  = reader["EventName"].ToString();
                return events;
            }
            return null;
        }
        public List<string> GetAllEvents(string userName)
        {
            string sql = "SELECT * FROM Events WHERE Username='"+userName+"'";
            SqlDataReader reader = this.GetData(sql);
            List<string> events = new List<string>();
            while (reader.Read())
            {
                Events events1 = new Events();
                events1.EventName = reader["EventName"].ToString();
                events.Add(events1.EventName);
            }
            return events;
        }

        public List<string> GetAllPictures(string eventName)
        {
            string sql = "SELECT * FROM Pictures WHERE EventName='" + eventName + "'";
            SqlDataReader reader = this.GetData(sql);
            List<string> pictures = new List<string>();
            while (reader.Read())
            {
                EventPictures eventPictures = new EventPictures();
                eventPictures.Pictures = reader["Pictures"].ToString();
                pictures.Add(eventPictures.Pictures);
            }
            return pictures;
        }

        public Events GetStory(string eventName)
        {
            string sql = "SELECT * FROM Events WHERE EventName='" + eventName + "'";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                Events events = new Events();
                events.EventStory = reader["Story"].ToString();
                events.EventDate = reader["EventDate"].ToString();
                events.Importance = reader["Importance"].ToString();
                return events;
            }
            return null;
        }
    }
}
