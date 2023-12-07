using RetselGames.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RetselGames.Entity.Entities
{
    public class Game : EntityBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
        public int DownloadCount { get; set; }
        public Guid PlatformId { get; set; }
        public Platform Platform { get; set; }
        public Guid? ImageId { get; set; }
        public Image Image { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
