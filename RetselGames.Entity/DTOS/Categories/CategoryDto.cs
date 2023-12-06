﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Entity.DTOS.Categories
{
	public class CategoryDto
	{
        public Guid Id { get; set; }
		public string Name { get; set; }
		public string CreatedBy { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime CreatedDate { get; set;}

    }
}
