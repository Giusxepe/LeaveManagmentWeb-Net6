using LeaveManagmentWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagmentWeb.Configurations.Entities
{
    internal class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "c77cba4b-0748-4efd-b77b-237972f1cfaf",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName= "ADMIN@LOCALHOST.COM",
                    UserName= "admin@localhost.com",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                 new Employee
                 {
                     Id = "4a31af3f-d4c7-4bab-9305-ba3c1cba988d",
                     Email = "user@localhost.com",
                     NormalizedEmail = "USER@LOCALHOST.COM",
                     NormalizedUserName= "USER@LOCALHOST.COM",
                     UserName= "user@localhost.com",
                     FirstName = "System",
                     LastName = "User",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed=true
                 }
             );
        }
    }
}