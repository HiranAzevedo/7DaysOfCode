using System.Net.Http.Json;
using TamagochiPokemonClient.Contracts;

namespace TamagochiPokemonClient
{
    public class PokemonClient
    {
        private static readonly HttpClient HttpClient = new() { BaseAddress = new Uri("https://pokeapi.co/api/v2/") };

        public static async Task<PokemonListResponse?> GetAllPokemonList()
        {
            var response = await HttpClient.GetAsync("pokemon/");

            var result = await response.Content.ReadFromJsonAsync<PokemonListResponse>();

            return result;
        }
    }
}