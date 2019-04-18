using System;
using System.Collections.Generic;
using System.Text;

namespace P11.PokemonTrainer
{
    public class Trainer
    {
        private List<Pokemon> pokemons = new List<Pokemon>();

        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public void AddPokemon(Pokemon pokemon)
        {
            this.Pokemons.Add(pokemon);
        }

        public void LoseHealth()
        {
            foreach (Pokemon pokemon in this.Pokemons)
            {
                pokemon.Health -= 10;
            }
        }
    }
}
