using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Number of Days")]
        [Range(1,25, ErrorMessage = "Invalid number entered.")]
        public int NumberOfDays { get;set; }
        [Required]
        [Display(Name = "Allocation period")]
        public int Period { get; set; }
        public LeaveTypeVM LeaveType { get; set; }
        public EmployeeListVM Employee { get; internal set; }
    }
}