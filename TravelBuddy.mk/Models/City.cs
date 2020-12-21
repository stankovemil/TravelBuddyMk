using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

namespace TravelBuddy.mk.Models
{
    public class City
    {

        
         [Key]
         public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Description { get; set; }
        [Required]
        public String Img1 { get; set; }
        [Required]
        public String Img2 { get; set; }
        [Required]
        public String Img3 { get; set; }

        [Display(Name ="Photos")]
        public List<String> Images { get; set; }
        public virtual List<Place> Places { get; set; }

        public City()
        {
            Images = new List<String>();
            Images.Add(Img1);
            Images.Add(Img2);
            Images.Add(Img3);
            Places = new List<Place>();
        }


        }
}