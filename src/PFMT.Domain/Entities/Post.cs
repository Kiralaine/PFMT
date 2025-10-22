using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFMT.Domain.Entities
{
    public class Post
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<PostFiles> Images { get; set; } = new List<PostFiles>();
        public long UserId { get; set; }
        public User User { get; set; }
    }

}
