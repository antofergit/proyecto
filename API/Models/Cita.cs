﻿using System;
using System.Collections.Generic;
using System.Text;

namespace API.Models
{
    public class Cita
    {
        public int IDCita { get; set; }
        public DateTime Fecha { get; set; }
        public int IDCliente { get; set; }
        public int IDMascota { get; set; }
    }
}
