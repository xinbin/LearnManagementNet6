using System.ComponentModel.DataAnnotations.Schema;

namespace LearnManagement.Web.Data
{
    public class LeaveRequest : BaseEntity
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; } = DateTime.MinValue;

        // This next two lines defines a foreign key
        // This will allow for the framework to make better inner joins
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        public DateTime DateRequested { get; set; }

        public string RequestComments { get; set; }

        public bool? Approved { get; set; }

        public bool Cancelled { get; set; }

        public string RequestingEmployeeId { get; set; }
    }
}
