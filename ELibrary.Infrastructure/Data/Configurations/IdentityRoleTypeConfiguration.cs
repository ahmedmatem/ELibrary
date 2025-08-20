using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELibrary.Infrastructure.Data.Configurations
{
    public class IdentityRoleTypeConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        private ICollection<IdentityRole> Roles = new HashSet<IdentityRole>();

        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            SeedRoles();
            builder.HasData(Roles);
        }

        private void SeedRoles()
        {
            Roles.Clear();
            Roles.Add(new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });
            Roles.Add(new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Teacher",
                NormalizedName = "TEACHER",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });
            Roles.Add(new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Student",
                NormalizedName = "STUDENT",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });
        }
    }
}
