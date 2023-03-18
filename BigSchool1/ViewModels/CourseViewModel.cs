using BigSchool1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BigSchool1.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate(ErrorMessage = "Date must be a valid future date in the format dd/MM/yyyy")]
        public string Date { get; set; }
        [Required]
        [ValidTime(ErrorMessage = "Time must be a valid time in the format hh:mm")]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.ParseExact(
            string.Format("{0} {1}", Date, Time),
            "dd/MM/yyyy HH:mm",
            CultureInfo.CurrentCulture);
        }
    }
}