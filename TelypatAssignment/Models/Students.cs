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
        public int CountryID { get; set; }
        public int ClassID { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("ClassID")]
        public Classes classses { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("CountryID")]
        public Countries countries { get; set; }

    }
}
