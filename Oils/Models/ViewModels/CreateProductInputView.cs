﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oils.Models.ViewModels
{
    public class CreateProductInputView
    {
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public string Viscosity { get; set; }
        public int PackageCapacity { get; set; }
        public decimal PackageWeight { get; set; }
    }
}
