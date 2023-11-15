﻿using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.NET6.Data
{
    public class Employee : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? TaxID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
