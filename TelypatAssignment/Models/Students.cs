using System;

namespace TelypayAssignment.Models
{
    public class Students
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string classes { get; set; }
        public string country { get; set; }
        public int birthDate { get; set; }
        public int Age { get { return DateTime.Now.Year - birthDate; } }
        

    }
}
