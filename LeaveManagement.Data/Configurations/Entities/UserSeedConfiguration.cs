using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            builder.HasData(
                new Employee
                {
                    Id = "76966784-f8cd-495f-bd12-206590117953",
                    UserName = "koshilolik@gmail.com",
                    NormalizedUserName = "KOSHILOLIK@GMAIL.COM",
                    Email = "koshilolik@gmail.com",
                    NormalizedEmail = "KOSHILOLIK@GMAIL.COM",
                    FirstName = "Oleg",
                    LastName = "Koshil",
                    PasswordHash = hasher.HashPassword(null, "!Koshil123"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "144e6a24-bd97-4459-9296-0f480a11d0c3",
                    UserName = "AndewGarcia22@gmail.com",
                    NormalizedUserName = "ANDEWGARCIA22@GMAIL.COM",
                    Email = "AndewGarcia22@gmail.com",
                    NormalizedEmail = "ANDEWGARCIA22@GMAIL.COM",
                    FirstName = "Andew",
                    LastName = "Garcia",
                    PasswordHash = hasher.HashPassword(null, "!Andrew123"),
                    EmailConfirmed = true
                }
            );
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }
    }
}