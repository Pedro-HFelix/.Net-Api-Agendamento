using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda.Models.Entities
{
    public class Tarefa
    {
        [Key]
        public int id { get; set; }
        public String titulo { get; set; }
        public String descricao { get; set; }
        public DateTime data { get; set; }
        public EnumStatusTarefa status { get; set; }
        
    }
}
