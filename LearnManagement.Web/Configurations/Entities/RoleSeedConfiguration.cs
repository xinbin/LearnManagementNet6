using LearnManagement.Web;
using LearnManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnManagement.Web.Configurations.Entities
{
    internal class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            // This method takes data that is comma separated and allows for creation of that in the db.
            builder.HasData(
                new IdentityRole
                {
                    Id = "5b159f10-79f3-44eb-9891-776f58352675",
                    Name = Roles.Adminstration,
                    NormalizedName = Roles.Adminstration.ToUpper()
                },
                new IdentityRole
                {
                    Id = "5b159f10-79f3-44eb-9891-776f58352674",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
             ); ;
        }
    }
}