using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetClinic.Models;
using System.Data.Entity;

namespace PetClinic.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AppointmentDate { get; set; }

        public int DoctorID { get; set; }
        public int ClientID { get; set; }
        public int RoomID { get; set; }
        [ForeignKey("DoctorID")]
        public virtual Doctor Doctor { get; set; }

        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }

        [ForeignKey("RoomID")]
        public virtual Room Room { get; set; }
    }
}