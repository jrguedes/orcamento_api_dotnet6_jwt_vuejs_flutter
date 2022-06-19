using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace orcamento_dotnet6_api.Models
{
    public class Orcamento : ModelBase
    {
        [Required]
        public DateTime Data { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public IEnumerable<ItemOrcamento> ItensOrcamento { get; set; }
    }
}
