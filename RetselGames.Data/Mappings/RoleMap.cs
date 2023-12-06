using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetselGames.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Data.Mappings
{
	public class RoleMap : IEntityTypeConfiguration<AppRole>
	{
		public void Configure(EntityTypeBuilder<AppRole> builder)
		{
			// Primary key
			builder.HasKey(r => r.Id);

			// Index for "normalized" role name to allow efficient lookups
			builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

			// Maps to the AspNetRoles table
			builder.ToTable("AspNetRoles");

			// A concurrency token for use with the optimistic concurrency checking
			builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

			// Limit the size of columns to use efficient database types
			builder.Property(u => u.Name).HasMaxLength(256);
			builder.Property(u => u.NormalizedName).HasMaxLength(256);

			// The relationships between Role and other entity types
			// Note that these relationships are configured with no navigation properties

			// Each Role can have many entries in the UserRole join table
			builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

			// Each Role can have many associated RoleClaims
			builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

			builder.HasData(new
				AppRole
			{
				Id = Guid.Parse("E00726F9-87C1-4540-AB1E-3B0D3135868D"),
				Name = "Superadmin",
				NormalizedName = "SUPERADMIN",
				ConcurrencyStamp = Guid.NewGuid().ToString()

			},

			new AppRole
			{
				Id = Guid.Parse("F9496293-0393-4FC7-A3D0-51D17DF4C821"),
				Name = "Admin",
				NormalizedName = "ADMIN",
				ConcurrencyStamp = Guid.NewGuid().ToString()
			},
			new AppRole
			{
				Id = Guid.Parse("50BF0616-6BFF-491C-800B-BFE7E8BFBBD9"),
				Name = "User",
				NormalizedName = "USER",
				ConcurrencyStamp = Guid.NewGuid().ToString()
			}
			);
		}
	}
}
