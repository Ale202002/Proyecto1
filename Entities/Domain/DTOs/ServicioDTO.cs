﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.DTOs
{
    public class ServicioDTO
    {
        public string NombreServicio { get; set; }
        public int Precio { get; set; }
        public ServicioDTO() { }
    }
}