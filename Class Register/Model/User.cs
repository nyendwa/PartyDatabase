using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Register.Model
{
    public class User
    {
        public User()
        {
            
        }
        public string? Name { get; set; }
        public string? NRC { get; set; }
        public string? Sex { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        public string? Constituency { get; set; }
        public string? Ward { get; set; }
    }
}
