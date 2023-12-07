using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "46988784-f0cd-495f-bd13-206591117952",
                    UserId = "76966784-f8cd-495f-bd12-206590117953"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "59425203-a9bb-495f-cc10-589390141783",
                    UserId = "144e6a24-bd97-4459-9296-0f480a11d0c3"
                }
            );
        }
    }
}