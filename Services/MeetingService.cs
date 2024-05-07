using STXAssignment.Interfaces;
using static STXAssignment.Controllers.MeetingsController;

namespace STXAssignment.Services
{
    public class MeetingService
    {
        public IMeetingServices _meetingServices;
        private readonly ILogger _logger;

        //Injecting the Dependency Object using Constructor means it is a Loose Coupling
        public MeetingService(IMeetingServices _meetingServices, ILogger logger)
        {
            this._meetingServices = _meetingServices;
            _logger = logger;
        }
        public List<Meeting> LoadMeetingDetails()
        {
            return _meetingServices.LoadMeetingDetails();
        }
        public Meeting? LoadMeetingDetailById(int id)
        {
            return _meetingServices.LoadMeetingDetailById(id);
        }
    }
}