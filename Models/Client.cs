using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Av9.Models
{
    public class Client
    {
        //kreirame i konstruktor
        public Client()
        {
            movies = new List<Movie>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ClientCard { get; set; }
        [Range(1,99)]
        public int Age { get; set; }

        //kreirame kolekcija od filmovi i taa ke ni bide viruelna 
        public virtual ICollection<Movie> movies { get; set; }

        //ova go napravivme za da kreirame edna megju tabela megju client i movie za da mozeme za daden film da znaeme koi klienti go rentale i da znaeme koj klient
        //koj drugi filmovi gi rental
        //posto dodadovme novo property mora vo console da napravime Add-migration i gi specificirame imeto, primer Add-Migration addedClientMovie
        //pa pisuvame update-database 
    }
}