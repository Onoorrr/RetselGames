using RetselGames.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Entity.Entities
{
    public class Platform : EntityBase
    {
        public string name { get; set; }

       public ICollection<Game> Games { get; set;}
    }
}
