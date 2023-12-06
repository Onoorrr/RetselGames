using Microsoft.AspNetCore.Identity;
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

			var superadmin = new AppUser
			{
				Id = Guid.Parse("9E753D47-8F3E-4CDE-B395-0260B2FE7960"),
				UserName = "superadmin@gmail.com",
				NormalizedUserName = "SUPERADMIN@GMAIL.COM",
				Email = "superadmin@gmail.com",
				NormalizedEmail = "SUPERADMIN@GMAIL.COM",
				PhoneNumber = "+905439999999",
				Name = "Onur",
				LastName = "Çelik",
				PhoneNumberConfirmed = true,
				EmailConfirmed = true,
				SecurityStamp = Guid.NewGuid().ToString()

			};
			superadmin.PasswordHash = CreatePasswordHash(superadmin, "123456");

			var admin = new AppUser
			{
				Id = Guid.Parse("9CBEC590-0916-4F4E-9D08-C65E561E81B1"),
				UserName = "admin@gmail.com",
				NormalizedUserName = "ADMIN@GMAIL.COM",
				Email = "admin@gmail.com",
				NormalizedEmail = "ADMIN@GMAIL.COM",
				PhoneNumber = "+905439999988",
				Name = "Onur",
				LastName = "Çelik",
				PhoneNumberConfirmed = false,
				EmailConfirmed = false,
				SecurityStamp = Guid.NewGuid().ToString()
			};
			admin.PasswordHash = CreatePasswordHash(admin, "123456");

			builder.HasData(superadmin, admin);


		}
		private string CreatePasswordHash(AppUser user, string password)
		{
			var passwordHasher = new PasswordHasher<AppUser>();
			return passwordHasher.HashPassword(user, password);
		}
	}
}
