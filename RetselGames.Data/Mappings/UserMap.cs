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
	public class UserMap : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			builder.HasKey(u => u.Id);

			// Indexes for "normalized" username and email, to allow efficient lookups
			builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
			builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

			// Maps to the AspNetUsers table
			builder.ToTable("AspNetUsers");

			// A concurrency token for use with the optimistic concurrency checking
			builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

			// Limit the size of columns to use efficient database types
			builder.Property(u => u.UserName).HasMaxLength(32);
			builder.Property(u => u.NormalizedUserName).HasMaxLength(32);
			builder.Property(u => u.Email).HasMaxLength(128);
			builder.Property(u => u.NormalizedEmail).HasMaxLength(128);

			// The relationships between User and other entity types
			// Note that these relationships are configured with no navigation properties

			// Each User can have many UserClaims
			builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

			// Each User can have many UserLogins
			builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

			// Each User can have many UserTokens
			builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

			// Each User can have many entries in the UserRole join table
			builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
		}
	}
}