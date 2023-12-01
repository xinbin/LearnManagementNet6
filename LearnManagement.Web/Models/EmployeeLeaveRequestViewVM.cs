using LearnManagement.Web.Data;

namespace LearnManagement.Web.Models
{
    public class EmployeeLeaveRequestViewVM
    {
        public EmployeeLeaveRequestViewVM(List<LeaveAllocationVM> leaveAllocations, List<LeaveRequestVM> leaveRequests)
        {
            LeaveAllocations = leaveAllocations;
            LeaveRequests = leaveRequests;
        }

        public List<LeaveAllocationVM> LeaveAllocations { get; set; }

        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }
}
