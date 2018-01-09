using CaserGroup.Automotive.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaserGroup.Automotive.Data.Interface
{
    public interface IAppointmentDal
    {
        bool AddAppointment(Appointment appointment);

        bool UpdateAppointment(Appointment appointment);

        bool DeleteAppointment(int id);

        Appointment GetAppointmentById(int id);

        List<Appointment> GetAppointments();
    }
}
