using LearnManagement.Web.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnManagement.Web.Models
{
    public class LeaveRequestVM
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; } = DateTime.MinValue;

        public LeaveTypeVM LeaveType { get; set; }

        public DateTime DateRequested { get; set; }

        public string? RequestComments { get; set; }

        public bool? Approved { get; set; }

        public bool Cancelled { get; set; }
    }
}
