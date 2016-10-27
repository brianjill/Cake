using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Domain;
using Cake.Interfaces;

namespace Cake
{
    public class IngredientsForStrawberryCheeseCake : AbstractCakeRule<Domain.Cake>, IRule
    {
        private readonly Domain.Cake _cake;
       
        public IngredientsForStrawberryCheeseCake(Domain.Cake cake)
        {
            _cake = cake;
       
        }

        public void ApplyRule()
        {
            if(!_cake.Type.Equals(CakeType.FlourlessCheese)) return;
            if (!_cake.Toppings.Any(f => f.Name.Contains("Strawberry"))) return;

            _cake.Name = "Strawberry Cheese Cake";
            _cake.Type = CakeType.FlourlessCheese;
            _cake.Ingredients = new List<Ingredient>()
            {
                new Ingredient
                {
                    Name = "Cream Cheese",
                    Amount = "100",
                    Measurement = "ml"
                },
                 new Ingredient
                {
                    Name = "Confectioners sugar",
                    Amount = "1/2",
                    Measurement = "cup"
                },
            };
        }
    }
}
