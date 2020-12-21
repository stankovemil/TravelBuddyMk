using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelBuddy.mk.Models
{
    public class Place
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public City City;
        [Required]
        public int Capacity { get; set; }
        [Required]
        public String Description { get; set; }
        [Required]
        public String imageUrl { get; set; }
        [Required]
        public int Price { get; set; }
    }
}