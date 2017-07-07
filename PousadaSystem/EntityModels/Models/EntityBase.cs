using System.ComponentModel.DataAnnotations;

namespace EntityModels
{
    public class EntityBase
    {
        [Key]
        public int ID { get; set; }
        public bool Deletado { get; set; }
    }
}
