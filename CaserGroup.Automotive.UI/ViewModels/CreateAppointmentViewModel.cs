using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaserGroup.Automotive.UI.ViewModels
{
    public class CreateAppointmentViewModel
    {
        public int Id { get; set; }

        [DisplayName("Müşteri")]
        public int CustomerId { get; set; }
        [DisplayName("Araç Markası")]
        public int VehicleId { get; set; }

        [DisplayName("Randevu Tarihi")]
        public DateTime AppointmentDate { get; set; }

        public List<SelectListItem> CustomersList { get; set; }
        public List<SelectListItem> VehiclesList { get; set; }
    }

}