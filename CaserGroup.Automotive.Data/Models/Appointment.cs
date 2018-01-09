using CaserGroup.Automotive.Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaserGroup.Automotive.Data.Models
{
    [Table("Appointment")]
    public class Appointment : IEntity
    {
        public int Id { get; set; }
        [DisplayName("Müşteri")]
        public int CustomerId { get; set; }
        [DisplayName("Araç Markası")]
        public int VehicleId { get; set; }
        [DisplayName("Randevu Tarihi")]
        public DateTime AppointmentDate { get; set; }
    }
}
