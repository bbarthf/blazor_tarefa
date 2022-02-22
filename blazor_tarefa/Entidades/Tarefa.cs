using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_tarefa.Entidades
{
    public class Tarefa
    {   // classe do projeto e nao mais local 
        // git e como se fosse uma sequence
        public Guid ID { get; set; }
        public String Descricao { get; set; }
        public bool Concluida { get; set; }
        public DateTime DataCriacao { get; set; }

    }
}
