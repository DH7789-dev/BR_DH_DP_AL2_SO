using System;
namespace BR_DH_DP_AL2;

public interface MenuSandwichRepository
{
	void add(Sandwich sandwich);

	List<Sandwich> getAll();
}

