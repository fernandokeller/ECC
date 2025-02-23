using System.Text.Json.Serialization;

namespace ECC.Web.Shared.Models.Country;

public class CountryIdentifier
{
    [JsonPropertyName("M49")]
    public int Id { get; set; }

    [JsonPropertyName("ISO-ALPHA-2")]
    public required string Code { get; set; }
}
