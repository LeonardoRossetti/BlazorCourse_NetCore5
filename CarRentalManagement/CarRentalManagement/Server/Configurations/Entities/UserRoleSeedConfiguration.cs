using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string> 
                {
                    RoleId = "f028f710-a0a6-49eb-aae7-361f5e244c48",
                    UserId = "f096080c-4822-4d47-9cc0-b32a01afc375"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "8b53b71b-c1e1-475c-8cd5-2cf13682c369",
                    UserId = "e71e49c5-ce9b-41cd-96b4-5dd02e41b07a"
                }
            );
        }
    }
}
