﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Entity.Entities
{
	public class AppUser : IdentityUser<Guid>
	{
		public string Name { get; set; }
		public string LastName { get; set; }

		public Guid? ImageId { get; set; }
		public Image Image { get; set; }	
		public ICollection<Category> Categories { get; set; }
	}
}
