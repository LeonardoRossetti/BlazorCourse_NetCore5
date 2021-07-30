using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole 
            {
                Id = "8b53b71b-c1e1-475c-8cd5-2cf13682c369",
                Name = "User",
                NormalizedName = "USER"
            },
            new IdentityRole
            {
                Id = "f028f710-a0a6-49eb-aae7-361f5e244c48",
                Name = "Administrator",
                NormalizedName = "ADMINISTATOR"
            });
        }
    }
}
