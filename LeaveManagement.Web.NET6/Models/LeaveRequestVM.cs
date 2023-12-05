using LeaveManagement.Web.NET6.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.NET6.Models
{
    public class LeaveRequestVM : LeaveRequestCreateVM
    {
        public int Id { get; set; }

        [Display(Name = "Date Requested")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateRequested { get; set; }

        [Display(Name = "Leave Type")]
        public LeaveTypeVM LeaveType { get; set; }

        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        
        public string? RequestingEmployeeId { get; set; }

        public EmployeeListVM Employee { get; set; }
    }
}
