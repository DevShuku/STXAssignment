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

        public async Task<List<Meeting>> LoadMeetingDetails()
        {
            var meetinglist = await _context.Meeting.ToListAsync();
            return meetinglist;
        }
        public async Task<Meeting?> LoadMeetingDetailById(int id)
        {
            return await _context.Meeting.FindAsync(id);
        }
    }
}