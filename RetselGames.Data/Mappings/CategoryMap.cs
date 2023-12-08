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
	public class CategoryMap : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasData(new Category
			{
				Id = Guid.NewGuid(),
				Name = "Psp",
				CreatedDate = DateTime.Now,
			}
			);
			//builder.Property(x => x.(Entitiy'nin değiştirmek istediğimiz propertysi.).HasMaxLength(150);
		}
	}
}
