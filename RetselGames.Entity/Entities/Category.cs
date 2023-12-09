using RetselGames.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Entity.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {
            
        }
        public Category(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public Guid? ImageId { get; set; }
        public Image? Image { get; set; }        
        public ICollection<Game> Games { get; set; }
    }
}
