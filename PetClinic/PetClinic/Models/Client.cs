using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PetClinic.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string ClientsName { get; set; }
        
    }
}