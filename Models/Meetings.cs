namespace STXAssignment.Controllers
{
    public partial class MeetingsController
    {
        // Define the Employee class
        public class Meeting
            {
                public int MeetingId { get; set; }
                public DateOnly Date { get; set; }
                public TimeOnly Time { get; set; }
                public List<Participant> Participants { get; set; }
                public string Agenda {  get; set; }

            public static implicit operator List<object>(Meeting v)
            {
                throw new NotImplementedException();
            }

            // Add any other properties as needed
        }
        }

    public class Participant
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
    