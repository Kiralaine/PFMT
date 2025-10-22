using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFMT.Domain.Entities
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int PfmtScore { get; set; }
        public Roles Role { get; set; }
        public List<Post> Posts { get; set; } = new List<Post>();


    }
    public enum Roles
    {
        Default,
        Admin,
        Dev
    }
}
