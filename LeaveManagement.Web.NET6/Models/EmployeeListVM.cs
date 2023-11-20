using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.NET6.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Date Joined")]
        public string DateJoined { get; set; }
        [Display(Name = "Email Adress")]
        public string Email { get; set; }
    }
}
