﻿using Microsoft.EntityFrameworkCore;
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
		}
	}
}
