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
	public class NewMap : IEntityTypeConfiguration<New>
	{
		public void Configure(EntityTypeBuilder<New> builder)
		{
			
		}
	}
}
