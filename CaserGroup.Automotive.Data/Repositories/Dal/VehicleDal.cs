using CaserGroup.Automotive.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaserGroup.Automotive.Data.Models;

namespace CaserGroup.Automotive.Data.Repositories.Dal
{
    public class VehicleDal : IVehicleDal
    {
        BaseRepository<Vehicle> operations = new BaseRepository<Vehicle>();
        public bool AddVehicle(Vehicle vehicle)
        {
            return operations.Add(vehicle);
        }

        public bool DeleteVehicle(int id)
        {
            return operations.Delete((GetVehicleById(id)));
        }

        public Vehicle GetVehicleById(int id)
        {
            return operations.GetOne(id);
        }

        public List<Vehicle> GetVehicles()
        {
            return operations.GetAll().ToList();
        }

        public bool UpdateVehicle(Vehicle vehicle)
        {
            return operations.Update(vehicle);
        }
    }
}
