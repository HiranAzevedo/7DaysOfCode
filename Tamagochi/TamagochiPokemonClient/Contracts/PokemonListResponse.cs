using System.Text.Json;
using System.Text.Json.Serialization;

namespace TamagochiPokemonClient.Contracts
{
    public class PokemonListResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("next")]
        public string? Next { get; set; }

        [JsonPropertyName("previous")]
        public string? Previous { get; set; }

        [JsonPropertyName("results")]
        public Result[]? Results { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true,
            });
        }
    }

    public class Result
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }
}