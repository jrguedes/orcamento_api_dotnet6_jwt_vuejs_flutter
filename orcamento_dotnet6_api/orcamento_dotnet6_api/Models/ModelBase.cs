using System.ComponentModel.DataAnnotations;

namespace orcamento_dotnet6_api.Models
{
    public class ModelBase
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }
    }
}
