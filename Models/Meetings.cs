﻿namespace STXAssignment.Controllers
{
   // public partial class MeetingsController
    //{
        // Define the Employee class
        public class Meeting
            {
                [Key]
                public int MeetingId { get; set; }
                public DateOnly Date { get; set; }
                public TimeOnly Time { get; set; }
                public string Participants { get; set; }
               // public List<Participant> Participants { get; set; }
                public string Agenda {  get; set; }

            public static implicit operator List<object>(Meeting v)
            {
                throw new NotImplementedException();
            }

            // Add any other properties as needed
        }
      //  }
    /*
    public class Participant
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    } */
}
    