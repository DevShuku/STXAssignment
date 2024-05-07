using Microsoft.AspNetCore.Mvc;
using STXAssignment.Interfaces;
using STXAssignment.Services;

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

        // Implement HTTP GET endpoint to retrieve the details of a specific meeting by ID
        [HttpGet("{id}")]
        public IActionResult GetMeetingsById(int id)
        {
            MeetingService _meetingService = new MeetingService(new MeetingDAL(), _logger);
            Meeting? meetingById = _meetingService.LoadMeetingDetailById(id);
            if (meetingById == null)
            {
                return NotFound(); // Return 404 Not Found if meeting with given ID is not found
            }
            return Ok(meetingById);
        }

        // Implement HTTP GET endpoint to retrieve the list of Meetings
        [HttpGet]
        [Route("MeetingsList")]
        public IActionResult GetMeetings()
        {
            try
            {
                MeetingService _meetingService = new MeetingService(new MeetingDAL(), _logger);
                List<Meeting> _meetings = _meetingService.LoadMeetingDetails();
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
