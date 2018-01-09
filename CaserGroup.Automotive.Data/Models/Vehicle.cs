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
    [Table("Vehicle")]
    public class Vehicle : IEntity
    {
        public int Id { get; set; }
        [DisplayName("Plaka")]
        public string Plate { get; set; }
        [DisplayName("Marka")]
        public string Brand { get; set; }
        [DisplayName("Model")]
        public string Model { get; set; }
        [DisplayName("Model Yıl")]
        public string ModelYear { get; set; }
    }
}
