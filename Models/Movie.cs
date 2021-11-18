using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Av9.Models
{
    public class Movie
    {
        public Movie()
        {
            clients = new List<Client>();
        }

        [Key]
        public int Id { get; set; }
        //dokolku sakame nekoe pole da ni bide zadolzitelno vnesuvame Required
        [Required]
        public string Name { get; set; }
        //dokolku ne sakame imeto da ni se prikazuva kako DownloadUrl moze da go promenime
        [Display(Name="The Download URL")]
        public string DownloadURL { get; set; }
        [Display(Name = "The Image URL")]
        public string ImageURL { get; set; }
        [Required]
        public float Rating { get; set; }

        public virtual ICollection<Client> clients { get; set; }

    }
}