using Microsoft.AspNetCore.Mvc;

namespace STXAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public partial class MeetingsController : ControllerBase
    {
        private readonly ILogger<MeetingsController> _logger;
        public MeetingsController(ILogger<MeetingsController> logger)
        {
            _logger = logger;
        }

        // Initialize the static List of Meetings objects
        private static List<Meeting> _meetings = new List<Meeting>
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
        // Implement HTTP GET endpoint to retrieve the details of a specific meeting by ID
        [HttpGet("{id}")]
        public IActionResult GetMeetingsById(int id)
        {
            var meetingById = _meetings.FirstOrDefault(c => c.MeetingId == id);
            if (meetingById == null)
            {
                return NotFound(); // Return 404 Not Found if meeting with given ID is not found
            }
            return Ok(meetingById); // Return 200 OK with the details of the meeting
        }

        // Implement HTTP GET endpoint to retrieve the list of Meetings
        [HttpGet]
        [Route("MeetingsList")]
        public IActionResult GetCustomers()
        {
            try
            {
                return Ok(_meetings);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return (IActionResult)ex;
            }
        }
    }
}
