using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private Dictionary<string, Hero> heroesList;

        public HeroRepository()
        {
            this.heroesList = new Dictionary<string, Hero>();
        }

        

        public int Count
        {
            get { return this.heroesList.Count; }
            
        }

        public void Add(Hero hero)
        {
            heroesList.Add(hero.Name, hero);
            //return heroesList.Count;
        }

        public void Remove(string name)
        {
            this.heroesList.Remove(name);
            //return this.heroesList.Count;
        }

        public Hero GetHeroWithHighestStrength()
        {
            Hero hero = new Hero("", 0, new Item(0, 0, 0));
            foreach (var item in heroesList.OrderByDescending(x => x.Value.Item.Strength))
            {
                hero = item.Value;
                break;
            }

            return hero;
            
        }

        public Hero GetHeroWithHighestAbility()
        {
            Hero hero = new Hero("", 0, new Item(0, 0, 0));
            foreach (var item in heroesList.OrderByDescending(x => x.Value.Item.Ability))
            {
                hero = item.Value;
                break;
            }

            return hero;

        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero hero = new Hero("", 0, new Item(0, 0, 0));
            foreach (var item in heroesList.OrderByDescending(x => x.Value.Item.Intelligence))
            {
                hero = item.Value;
                break;
            }

            return hero;

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in heroesList)
            {
                sb.Append( item.Value.ToString());
            }
            return sb.ToString();
        }
    }
}
