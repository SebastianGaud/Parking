﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park.Business.Dtos
{
    public class CarDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Plate { get; set; }
        public string Model { get; set; }
    }
}
