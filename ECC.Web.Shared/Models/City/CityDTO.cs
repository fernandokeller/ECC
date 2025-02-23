using System.Text.Json.Serialization;

namespace ECC.Web.Shared.Models.City;

public class CityDTO
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nome")]
    public required string Name { get; set; }
}
