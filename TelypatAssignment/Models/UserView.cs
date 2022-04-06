using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelypayAssignment.Models
{
    public class UserView
    {
        public IEnumerable<Students> Students { get; set; }
        public IEnumerable<Countries> Countries { get; set; }
        public IEnumerable<Classes> Classses { get; set; }



    }
}
