using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelypayAssignment.Models
{
    public class Students
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string classes { get; set; }
        public string country { get; set; }
        public string birthDate { get; set; }
     /*   public int stdage
        {
            get;
            set;

        }*/
    }
}
