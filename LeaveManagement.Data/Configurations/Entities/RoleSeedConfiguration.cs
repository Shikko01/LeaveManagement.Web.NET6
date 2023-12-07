using LeaveManagement.Common.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData
           (
                new IdentityRole
                {
                    Id = "46988784-f0cd-495f-bd13-206591117952",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "59425203-a9bb-495f-cc10-589390141783",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
           ) ;
        }
    }
}