using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Av9.Models
{
    public class MovieRentals
    {
        public Movie movie { get; set; }
        public List<Client> clients { get; set; }

        //zato so imame lista mora da naprajme konstruktor
        public MovieRentals()
        {
            //ova go pravime zato sto ako sakame da dodademe nov klient vo listata ke dobieme null pointer exception
            clients = new List<Client>();
        }
    }
}