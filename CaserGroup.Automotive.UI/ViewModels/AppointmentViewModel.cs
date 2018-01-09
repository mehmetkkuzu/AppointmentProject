using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CaserGroup.Automotive.UI.ViewModels
{
    public class AppointmentViewModel
    {
        public int Id { get; set; }
        [DisplayName("Müşteri")]
        public string CustomerName { get; set; }
        [DisplayName("Araç Markası")]
        public string VehicleBrand { get; set; }
        [DisplayName("Randevu Tarihi")]
        public DateTime AppointmentDate { get; set; }
    }
}