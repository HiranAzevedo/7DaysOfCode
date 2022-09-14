// See https://aka.ms/new-console-template for more information

using TamagochiPokemonClient;

Console.WriteLine("Listing the first 20 pokemons");
Console.WriteLine(await PokemonClient.GetAllPokemonList());
Console.ReadKey();