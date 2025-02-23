using System.Text.Json.Serialization;

namespace ECC.Web.Shared.Models.Address;

public class AddressDTO
{
    [JsonPropertyName("cep")]
    public string? ZipCode { get; set; }

    [JsonPropertyName("logradouro")]
    public required string Address { get; set; }

    [JsonPropertyName("bairro")]
    public required string Neighborhood { get; set; }

    [JsonPropertyName("uf")]
    public required string UF { get; set; }
}
