using RetselGames.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetselGames.Entity.Entities
{
    public class Image : EntityBase
    {

        public Image()
        {
            
        }
        public Image(string fileName,string fileType)
        {
            FileName = fileName;
            FileType = fileType;
        }

        public string FileName { get; set; }
        public string FileType { get; set; }
        public ICollection<Game> Games { get; set; }
        public ICollection<New> News { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<AppUser> Users { get; set; }


    }
}
