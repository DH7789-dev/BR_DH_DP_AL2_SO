using System;
namespace BR_DH_DP_AL2
{
	public class Ingrediant
	{
        private string name;

        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public Ingrediant(string name)
        {
            this.name = name;
        }
    }
}

