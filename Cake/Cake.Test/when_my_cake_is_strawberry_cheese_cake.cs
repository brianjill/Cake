using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Domain;
using FluentAssertions;
using Machine.Specifications;

namespace Cake.Test
{
    public class when_my_cake_is_strawberry_cheese_cake : a_cheese_cake
    {
        private Establish _context;

        public when_my_cake_is_strawberry_cheese_cake()
        {
            _context = () =>
            {
                MyCake = new Domain.Cake
                {
                    Type = CakeType.FlourlessCheese,
                    Toppings = new List<Top>
                    {
                        new Top
                        {
                            Name = "Strawberry"
                        }
                    }
                };
                MyBaking = new Bake();
            };
        }

        private Because of = () => MyBaking.GatherIngredients(MyCake);

        private It should_contain_name_Strawberry_Cheese_Cake = () => MyCake.Name.Contains("Strawberry Cheese Cake");

        private It should_have_a_cream_cheese_ingredient = () => MyCake.Ingredients.Any(i=>i.Name.Contains("Cream Cheese"));
        

    }
}
