using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Domain;
using Cake.Interfaces;

namespace Cake
{
    public class Bake : IBake
    {

        public void GatherIngredients(Domain.Cake cake)
        {
            var cakeIngredients = new List<IRule>
                            {
                                new IngredientsForStrawberryCheeseCake(cake),
                                new IngredientsForTaisanCake(cake)
                                
                            };

            foreach (var cakeIngredient in cakeIngredients)
            {
                cakeIngredient.ApplyRule();
            }
        }

        public void Mix(Domain.Cake cake)
        {
            var cakeMixes = new List<IRule>
                            {
                                //new MixForCheeseCake(cake),
                                //new MixForButter(cake)
                                //new MixForChiffon(cake) 
                            };

            foreach (var cakeMix in cakeMixes)
            {
                cakeMix.ApplyRule();
            }
        }

        public void Cook()
        {
            throw new NotImplementedException();
        }

        public void Chill()
        {
            throw new NotImplementedException();
        }

        public void Decorate()
        {
            throw new NotImplementedException();
        }
    }

    

    public interface IBake
    {
        void GatherIngredients(Domain.Cake cake);
        void Mix(Domain.Cake cake);
        void Cook();
        void Chill();
        void Decorate();
    }
}
