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
        public int GetAvgAge { get { return( DateTime.Now.Year - birthDate)/2; } }
        public int calculateAverage(int[] age)
        {   
            var len = age.Length;
            var sum = 0;
            for (int i = 0; i < len; i++)
            {
                sum += age[i];
            }
            var avg = sum / len;
            return avg;
        }

    }
}
