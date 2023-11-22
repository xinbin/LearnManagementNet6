using LearnManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "5b159f10-79f3-44eb-9891-776f58352675",
                    UserId = "5b159f10-76a3-9891-44eb-776f58352674"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "5b159f10-79f3-44eb-9891-776f58352674",
                    UserId = "9f105b15-76a3-44eb-9891-776f58352674"
                }
            );
        }
    }
}