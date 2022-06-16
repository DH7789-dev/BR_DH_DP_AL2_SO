using System;
namespace BR_DH_DP_AL2;

public interface OrderRepository
{
	void add(Sandwich sandwich);

	List<Sandwich> getAll();
}

