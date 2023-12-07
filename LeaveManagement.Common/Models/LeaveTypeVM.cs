using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default number of days")]
        [Required]
        [Range(1,21, ErrorMessage = "Please, enter a valid number.")]
        public int DefaultDays { get; set; }
    }
}
