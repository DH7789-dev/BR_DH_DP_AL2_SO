using System;

namespace BR_DH_DP_AL2;

public class ImplMenuSandwich:MenuSandwichRepository
{

    private List<Sandwich> _sandwiches;

    public ImplMenuSandwich()
	{
        _sandwiches = new List<Sandwich>();
    }

    public void add(Sandwich sandwich)
    {
        _sandwiches.Add(sandwich);
    }

    public List<Sandwich> getAll()
    {
        return _sandwiches;
    }
}


