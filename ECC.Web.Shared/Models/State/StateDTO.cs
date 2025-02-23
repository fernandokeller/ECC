using System.Text.Json.Serialization;

namespace ECC.Web.Shared.Models.State;

public class StateDTO
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("sigla")]
    public required string UF { get; set; }

    [JsonPropertyName("nome")]
    public required string Name { get; set; }
}
