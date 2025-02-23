using System.Text.Json.Serialization;

namespace ECC.Web.Shared.Models.Country;

public class CountryDTO
{
    [JsonPropertyName("id")]
    public required CountryIdentifier Identifier { get; set; }

    [JsonPropertyName("nome")]
    public required string Name { get; set; }
}
