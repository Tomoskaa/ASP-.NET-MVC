using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Av9.Models
{
    public class ClientMovie
    {
        public Movie movie { get; set; }
        public List<Client> clients { get; set; }
        public int MovieId { get; set; }
        public int ClientId { get; set; }
    }
}