using System;

namespace blazor_tarefa.Entidades
{
    /// <summary>
    /// Classe para definir os valores de tarefa no sistema
    /// </summary>
    public class Tarefa
    {   /// <summary>
        /// Identificador unico PK 
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// Descricao da tarefa 
        /// </summary>
        public String Descricao { get; set; }
        /// <summary>
        /// Status da tarefa
        /// </summary>
        public bool Concluida { get; set; }
        /// <summary>
        /// Data de criacao da tarefa 
        /// </summary>
        public DateTime DataCriacao { get; set; }

    }
}
