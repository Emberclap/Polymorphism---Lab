using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        private string name;
        private string favoriteFood;

        protected Animal(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavoriteFood = favoriteFood;
        }
        public string Name { get; protected set; }
        public string FavoriteFood { get; protected set; }

        public virtual string ExplainSelf()
        {
            return $"I am {this.name} and my favourite food is {this.FavoriteFood}";
        }
    }
}
