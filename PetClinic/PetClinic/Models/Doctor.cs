using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PetClinic.Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
    }
}