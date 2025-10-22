using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFMT.Domain.Entities
{
    public class PostFiles
    {
        public long Id { get; set; }
        public string FileURL { get; set; }
        public long PostId { get; set; }
        public Post Post { get; set; }
    }

}
