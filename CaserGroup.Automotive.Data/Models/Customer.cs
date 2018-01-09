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
    [Table("Customer")]
    public class Customer : IEntity
    {
        public int Id { get; set; }
        [DisplayName("Ad Soyad")]
        public string Name { get; set; }
        [DisplayName("Telefon")]
        public string Phone { get; set; }
        [DisplayName("E-Posta")]
        public string Email { get; set; }
    }
}
