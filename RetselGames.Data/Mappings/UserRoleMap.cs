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
	public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
	{
		public void Configure(EntityTypeBuilder<AppUserRole> builder)
		{
			// Primary key
			builder.HasKey(r => new { r.UserId, r.RoleId });

			// Maps to the AspNetUserRoles table
			builder.ToTable("AspNetUserRoles");

			builder.HasData(new AppUserRole
			{
				//Superadmin
				UserId = Guid.Parse("9E753D47-8F3E-4CDE-B395-0260B2FE7960"),
				RoleId = Guid.Parse("E00726F9-87C1-4540-AB1E-3B0D3135868D")
			},

			new AppUserRole
			{
				//Admin
				UserId = Guid.Parse("9CBEC590-0916-4F4E-9D08-C65E561E81B1"),
				RoleId = Guid.Parse("F9496293-0393-4FC7-A3D0-51D17DF4C821"),


			}
				);
		}
	}
}
