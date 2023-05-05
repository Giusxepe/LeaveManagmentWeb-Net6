using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagmentWeb.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "1699e545-7b30-4708-91cd-4d8cfff5bb8d",
                    UserId= "c77cba4b-0748-4efd-b77b-237972f1cfaf"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "d64051cd-d770-42bf-bd0e-b6e020c4b1e9",
                    UserId = "4a31af3f-d4c7-4bab-9305-ba3c1cba988d"
                }
             );
        }
    }
}