using CaserGroup.Automotive.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaserGroup.Automotive.Data.Models;

namespace CaserGroup.Automotive.Data.Repositories.Dal
{
    public class AppointmentDal : IAppointmentDal
    {
        BaseRepository<Appointment> operations = new BaseRepository<Appointment>();

        public bool AddAppointment(Appointment appointment)
        {
            return operations.Add(appointment);
        }

        public bool DeleteAppointment(int id)
        {
            return operations.Delete((GetAppointmentById(id)));
        }

        public Appointment GetAppointmentById(int id)
        {
            return operations.GetOne(id);
        }

        public List<Appointment> GetAppointments()
        {
            return operations.GetAll().ToList();
        }

        public bool UpdateAppointment(Appointment appointment)
        {
            return operations.Update(appointment);
        }
         
    }
}
