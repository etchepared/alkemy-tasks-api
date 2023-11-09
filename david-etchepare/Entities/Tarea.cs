using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace david_etchepare.Entities
{
    [Table("Tareas")]
    public class Tarea
    {
        [Key]
        [Column("tarea_id")]
        public int Id { get; set; }
       
        [Column("tarea_title", TypeName = "VARCHAR(100)")]
        public string TareaTitle { get; set; }
        
        [Column("tarea_description", TypeName = "VARCHAR(100)")]
        public string TareaDescription { get; set; }
        
        [Column("tarea_isCompleted")]
        public bool IsCompleted { get; set; }

    }
}
