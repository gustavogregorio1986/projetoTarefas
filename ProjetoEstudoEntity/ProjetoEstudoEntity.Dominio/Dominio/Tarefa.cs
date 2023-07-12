﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudoEntity.Dominio.Dominio
{
    public class Tarefa
    {
        public int Id { get; set; }

        public string? Titulo { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public string? Descricao { get; set; }
    }
}
