using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetClinic.Models
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        [Index(IsUnique=true)]
        public int RoomNumber { get; set; }
        
    }
}