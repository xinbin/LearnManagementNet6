using LearnManagement.Web.Contracts;
using LearnManagement.Web.Data;

namespace LearnManagement.Web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        public LeaveAllocationRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task LeaveAllocation(int leaveTypeId)
        {
            throw new NotImplementedException();
        }
    }
}
