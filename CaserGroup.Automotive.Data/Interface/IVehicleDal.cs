using CaserGroup.Automotive.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaserGroup.Automotive.Data.Interface
{
    public interface IVehicleDal
    {
        bool AddVehicle(Vehicle vehicle);

        bool UpdateVehicle(Vehicle vehicle);

        bool DeleteVehicle(int id);

        Vehicle GetVehicleById(int id);

        List<Vehicle> GetVehicles();
    }
}
