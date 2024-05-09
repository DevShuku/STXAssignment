using STXAssignment.Controllers;
using STXAssignment.Data;

namespace STXAssignment.Services
{
    public class MeetingService : IMeetingServices
    {
      //  public IMeetingServices _meetingServices;
        private readonly AppDbContext _context;
        private ILogger<MeetingsController> logger;

        //Injecting the Dependency Object using Constructor means it is a Loose Coupling
        public MeetingService(ILogger<MeetingsController> logger, AppDbContext context)
        {
            _context = context;
            this.logger = logger;
        }

        public List<Meeting> LoadMeetingDetails()
        {
            var meetinglist = _context.Meeting.ToList();
            return meetinglist;
            //return _meetingServices.LoadMeetingDetails();
        }
        public Meeting? LoadMeetingDetailById(int id)
        {
            var _meetingList = _context.Meeting.ToList();
            var meetingById = _meetingList.FirstOrDefault(c => c.MeetingId == id);
            return meetingById;
           // return _meetingServices.LoadMeetingDetailById(id);
        }
    }
}