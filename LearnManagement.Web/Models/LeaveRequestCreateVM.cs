using LearnManagement.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnManagement.Web.Models
{
    public class LeaveRequestCreateVM : IValidatableObject 
    {
        [Required]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
        [Required]
        public int LeaveTypeId { get; set; }

        public SelectList LeaveTypes { get; set; }
        [Display(Name = "Comments")]
        public string RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield return ModelState.AddModelError(string.Empty, "An Error Has Occurred. Please try again later");
        }
    }
}
