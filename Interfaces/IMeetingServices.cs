using STXAssignment.Controllers;

//Service Class or Dependency Object
//Dependency Object should be Interface-Based
    public interface IMeetingServices
    {
        Task<List<Meeting>> LoadMeetingDetails();

        Task<Meeting?> LoadMeetingDetailById(int id);
    }

   /* public class MeetingDAL : IMeetingServices
    {
        // Initialize the static List of Meetings objects
        /* List<Meeting> MeetingList = new List<Meeting>
         {
           new Meeting
           {
             MeetingId = 1,
             Date = new DateOnly(2024, 05, 01),
             Time = new TimeOnly(10, 30),
             Participants = new List<Participant>
             {
               new Participant { Name = "Paul Adam", Role = "Sales Manager" }
             },
             Agenda = "Discuss new product line collaboration"
           },
           new Meeting
           {
             MeetingId = 2,
             Date = new DateOnly(2024, 05, 02),
             Time = new TimeOnly(11, 30),
             Participants = new List<Participant>
             {
               new Participant { Name = "Sophia Lee", Role = "Supply Chain Manager" },
               new Participant { Name = "Daniel Garcia", Role = "Finance Director" },
               new Participant { Name = "David Lee", Role = "Logistics Coordinator" }
             },
             Agenda = "Review quarterly performance and plan for upcoming logistics improvements"
           },
           new Meeting
           {
             MeetingId = 3,
             Date = new DateOnly(2024, 05, 03),
             Time = new TimeOnly(12, 30),
             Participants = new List<Participant>
             {
               new Participant { Name = "Alexandra Kim", Role = "CEO" },
               new Participant { Name = "Matthew Brown", Role = "CFO" },
               new Participant { Name = "Olivia Wang", Role = "Marketing Manager" }
             },
             Agenda = "Strategy meeting for expanding into new markets"
           }
         };
        */

        /*List<Meeting> MeetingList = new List<Meeting>
        {
          new Meeting
          {
            MeetingId = 1,
            Date = new DateOnly(2024, 05, 01),
            Time = new TimeOnly(10, 30),
            Participants = "Paul Adam",
            Agenda = "Discuss new product line collaboration"
          },
          new Meeting
          {
            MeetingId = 2,
            Date = new DateOnly(2024, 05, 02),
            Time = new TimeOnly(11, 30),
            Participants = "Sophia Lee", 
            Agenda = "Review quarterly performance and plan for upcoming logistics improvements"
          },
          new Meeting
          {
            MeetingId = 3,
            Date = new DateOnly(2024, 05, 03),
            Time = new TimeOnly(12, 30),
            Participants = "Alexandra Kim",
            Agenda = "Strategy meeting for expanding into new markets"
          }
        };

       
        

        public Meeting? LoadMeetingDetailById(int id)
        {
            var MeetingById = MeetingList.FirstOrDefault(c => c.MeetingId == id);
            return MeetingById;
        }

        public List<Meeting> LoadMeetingDetails()
        {            
            return MeetingList;
        } 
    } 
}*/