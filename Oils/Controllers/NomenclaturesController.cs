using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oils.Services;

namespace Oils.Controllers
{
    public class NomenclaturesController: Controller
    {
        private readonly INomenclaturesService _nomenclaturesService;

        public NomenclaturesController(INomenclaturesService nomenclaturesService)
        {
            _nomenclaturesService = nomenclaturesService;
        }
        public IActionResult All()
        {

            var nomenclatures = new Dictionary<string, int>()
            {
                ["Products"] = _nomenclaturesService.GetRecordings("Products"),
                ["Receivers"] = _nomenclaturesService.GetRecordings("Receivers"),
                ["Carriers"] = _nomenclaturesService.GetRecordings("Carriers"),
                ["Vehicles"] = _nomenclaturesService.GetRecordings("Vehicles"),
                ["Drivers"] = _nomenclaturesService.GetRecordings("Drivers"),
            };
            return this.View(nomenclatures);
        }
        public IActionResult Products()
        {
            var model = _nomenclaturesService.All("Products");
            return this.View(model);
        }
        public IActionResult Receivers()
        {
            var model = _nomenclaturesService.All("Receivers");
            return this.View(model);
        }
        public IActionResult Carriers()
        {
            var model = _nomenclaturesService.All("Carriers");
            return this.View(model);
        }
        public IActionResult Vehicles()
        {
            var model = _nomenclaturesService.All("Vehicles");
            return this.View(model);
        }
        public IActionResult Drivers()
        {
            var model = _nomenclaturesService.All("Drivers");
            return this.View(model);
        }
    }
}
