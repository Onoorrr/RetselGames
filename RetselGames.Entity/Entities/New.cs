using RetselGames.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Entity.Entities
{
    public class New : EntityBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid? ImageId { get; set; }
        public Image Image { get; set; }




    }
}
