using System;

namespace BR_DH_DP_AL2
{
	public class Sandwich
	{
        private string _name;
        private List<Ingrediant> _ingredients;
        private double _price;

        public string Name    // the Name property
        {
            get => _name;
            set => _name = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public List<Ingrediant> Ingredients   // the Name property
        {
            get => _ingredients;
            set => _ingredients = value;
        }

        public Sandwich(string name, List<Ingrediant> ingredients, double price)
        {
            _name = name;
            _ingredients = ingredients;
            _price = price;
        }
    }
}

