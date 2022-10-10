﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Logistica
{
    public class RoteiroMotorista
    {      
        public virtual int RoteiroId { get; set; }
        public virtual DateTime DataEntrada { get; set; }
        public virtual string? Proposta { get; set; }
        public virtual string? Obra { get; set; }
        public virtual string? Funcionario { get; set; }
    
    }
}
