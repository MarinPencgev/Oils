using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Oils.Data.Domains;
using Oils.Models.ViewModels;
using Oils.Services;

namespace Oils.Controllers
{
    public class ReceiversController : Controller
    {
        private readonly IReceiverService _receiversService;
        private readonly IMapper _mapper;

        public ReceiversController(IReceiverService receiversService,IMapper mapper)
        {
            _receiversService = receiversService;
            _mapper = mapper;
        }
        public IActionResult Edit(string id)
        {
            var receiver = _receiversService.GetReceiverById(id);
            var model = _mapper.Map<EditReceiverEntityViewModel>(receiver);
            return this.View("Edit", model);
        }
        [HttpPost]
        public IActionResult Edit(EditReceiverEntityViewModel input)
        {
            var receiver = _mapper.Map<Receiver>(input);
            return this.View();
        }
    }
}
