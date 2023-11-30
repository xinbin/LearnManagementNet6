using System.ComponentModel.DataAnnotations.Schema;

namespace LearnManagement.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }
        // This next two lines defines a foreign key
        // This will allow for the framework to make better inner joins
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        // This is not creating a foreign key but we are still uniting the data?
        // When to make a FK and when it's not needed?\
        public string EmployeeId { get; set; }
        public int Period { get; set; }
    }
}
