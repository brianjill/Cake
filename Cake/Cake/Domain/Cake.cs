using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake.Domain
{
    public class Cake
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        //menu
        public CakeType Type { get; set; }
        public List<Flavour> Flavours { get; set; }
        public List<Top> Toppings { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }
}
