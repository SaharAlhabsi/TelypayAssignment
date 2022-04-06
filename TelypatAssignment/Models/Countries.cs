using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelypayAssignment.Models
{
    public class Countries
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string total { get; set; }

    }
}
