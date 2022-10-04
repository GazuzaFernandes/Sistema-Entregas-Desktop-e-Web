﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Logistica
{
    public class Usuario
    {
        public virtual int UsuarioId { get; set; }
        public virtual string? Senha { get; set; }
        public virtual bool Ativo { get; set; }
    }
}
