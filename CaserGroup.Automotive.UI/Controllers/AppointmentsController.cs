using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CaserGroup.Automotive.Data.DataContext;
using CaserGroup.Automotive.Data.Models;
using CaserGroup.Automotive.Data.Repositories.Dal;
using CaserGroup.Automotive.UI.ViewModels;

namespace CaserGroup.Automotive.UI.Controllers
{
    public class AppointmentsController : Controller
    {
        private CustomerDal Customers = new CustomerDal();
        private VehicleDal Vehicles = new VehicleDal();
        private AppointmentDal Appointments = new AppointmentDal();

        // GET: Appointments
        public ActionResult Index()
        {
            List<AppointmentViewModel> listModel = new List<AppointmentViewModel>();

            var listOfAppointment = Appointments.GetAppointments();
            foreach (var item in listOfAppointment)
            {
                AppointmentViewModel model = new AppointmentViewModel();
                model.Id = item.Id;
                model.CustomerName = Customers.GetCustomerById(item.CustomerId).Name;
                model.VehicleBrand = Vehicles.GetVehicleById(item.VehicleId).Brand;

                listModel.Add(model);
            }
            return View(listModel);
        }

        // GET: Appointments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointment appointment = Appointments.GetAppointmentById(id.Value);

            AppointmentViewModel model = new AppointmentViewModel();
            model.Id = appointment.Id;
            model.CustomerName = Customers.GetCustomerById(appointment.CustomerId).Name;
            model.VehicleBrand = Vehicles.GetVehicleById(appointment.VehicleId).Brand;

            if (appointment == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // GET: Appointments/Create
        public ActionResult Create()
        {
            CreateAppointmentViewModel model = new CreateAppointmentViewModel();

            List<SelectListItem> itemsCustomer = new List<SelectListItem>();

            foreach (var item in Customers.GetCustomers())
            {
                var x = new SelectListItem { Value = item.Id.ToString(), Text = item.Name };
                itemsCustomer.Add(x);
            }
            model.CustomersList = itemsCustomer;
            List<SelectListItem> itemsVehicles = new List<SelectListItem>();
            foreach (var item in Vehicles.GetVehicles())
            {
                var x = new SelectListItem { Value = item.Id.ToString(), Text = item.Brand };
                itemsVehicles.Add(x);
            }
            model.VehiclesList = itemsVehicles;
            return View(model);
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CustomerId,VehicleId,AppointmentDate")] Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                Appointments.AddAppointment(appointment);
                return RedirectToAction("Index");
            }

            return View(appointment);
        }

        // GET: Appointments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var appointment = Appointments.GetAppointmentById(id.Value);
            if (appointment == null)
            {
                return HttpNotFound();
            }

            CreateAppointmentViewModel model = new CreateAppointmentViewModel();

            List<SelectListItem> itemsCustomer = new List<SelectListItem>();

            foreach (var item in Customers.GetCustomers())
            {
                var x = new SelectListItem { Value = item.Id.ToString(), Text = item.Name };
                itemsCustomer.Add(x);
            }
            model.CustomersList = itemsCustomer;
            List<SelectListItem> itemsVehicles = new List<SelectListItem>();
            foreach (var item in Vehicles.GetVehicles())
            {
                var x = new SelectListItem { Value = item.Id.ToString(), Text = item.Brand };
                itemsVehicles.Add(x);
            }
            model.VehiclesList = itemsVehicles;
            model.Id = id.Value;
            return View(model);
        }

        // POST: Appointments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CustomerId,VehicleId,AppointmentDate")] Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                Appointments.UpdateAppointment(appointment);
                return RedirectToAction("Index");
            }
            return View(appointment);
        }

        // GET: Appointments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointment appointment = Appointments.GetAppointmentById(id.Value);
            if (appointment == null)
            {
                return HttpNotFound();
            }
            return View(appointment);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Appointments.DeleteAppointment(id);
            return RedirectToAction("Index");
        }

    }
}
