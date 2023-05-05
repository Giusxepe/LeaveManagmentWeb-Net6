using LeaveManagmentWeb.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagmentWeb.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "1699e545-7b30-4708-91cd-4d8cfff5bb8d",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                 new IdentityRole
                 {
                     Id = "d64051cd-d770-42bf-bd0e-b6e020c4b1e9",
                     Name = Roles.User,
                     NormalizedName = Roles.User.ToUpper()
                 }
                );
        }
    }
}