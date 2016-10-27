using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Domain;
using Cake.Interfaces;

namespace Cake
{
    public class IngredientsForTaisanCake : AbstractCakeRule<Domain.Cake>, IRule
    {
        private readonly Domain.Cake _cake;
       

        public IngredientsForTaisanCake(Domain.Cake cake)
        {
            _cake = cake;
            
        }

        public void ApplyRule()
        {
            if(!_cake.Type.Equals(CakeType.Chiffon)) return;
            if (!_cake.Toppings.Any(f => f.Name.Contains("Cheddar"))) return;

            _cake.Name = "Taisan Cake";
            _cake.Type = CakeType.Chiffon;
            _cake.Ingredients = new List<Ingredient>()
            {
                new Ingredient
                {
                    Name = "Egg Whites",
                    Amount = "6",
                    Measurement = "count"
                },
                 new Ingredient
                {
                    Name = "Evaporated Milk",
                    Amount = "1",
                    Measurement = "can"
                },
            };
        }
    }
}
