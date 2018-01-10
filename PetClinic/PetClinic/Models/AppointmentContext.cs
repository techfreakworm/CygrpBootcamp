using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetClinic.Models
{
    
    public class AppointmentContext : DbContext
    {

        public AppointmentContext() : base("name=PetClinicDb")
        { }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}