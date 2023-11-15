namespace LeaveManagement.Web.NET6.Data
{
    // For the concept of DRY
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
