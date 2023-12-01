using LeaveManagement.Web.NET6.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.NET6.Models
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
        [Display(Name = "Leave Type")]
        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes { get; set; }
        [Required]
        [Display(Name = "Request Comments")]
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate > EndDate)
            {
                yield return new ValidationResult("The Start Date must be after End Date.", new[] { nameof(StartDate), nameof(EndDate) });
            }

            // just for example to me
            if (RequestComments?.Length > 250)
            {
                yield return new ValidationResult("Comment are too long.", new[] { nameof(RequestComments)});
            }

            // Аби уникнути помилки, адже string в базі даних у нас не може дорівнювати null, то потрібно добавити цю валідацію поля з текстом,
            // або добавити тег [Required] для поля з цим текстом. Зупинюсь на другому варіанті. Або ж зробити нову міграцію і зробити це поле 
            // таким, яке зможе приймати значення null.
            /*
            if (RequestComments == null)
            {
                yield return new ValidationResult("Request comments is blank.", new[] { nameof(RequestComments) });
            }
            */
        }
    }
}
