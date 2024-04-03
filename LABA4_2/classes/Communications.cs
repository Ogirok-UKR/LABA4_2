﻿using System;

public class Communications
{
	private List<Tariff> Tariffs = new List<Tariff>();
	public Communications()
	{

	}
	public Communications(List<Tariff> Tariffs)
	{
		this.Tariffs = Tariffs;
	}

	public void AddTariff(Tariff Tariff)
	{
		Tariffs.Add(Tariff);
	}

	public void RemoveTariff(string TariffName)
	{
		foreach (Tariff Tariff in Tariffs)
		{
			if (Tariff.Name == TariffName)
			{
				Tariffs.Remove(Tariff);
			}
		}
	}

	public void RemoveTariff(Tariff Tariff)
	{
		Tariffs.Remove(Tariff);
	}

	public int NumberOfClients()
	{
		int NumberOfClients = 0;
		foreach (Tariff Tariff in Tariffs) 
		{
			NumberOfClients += Tariff.NumberOfClients;
		}
		return NumberOfClients;
	}

	public void SortByPriceAscending()
	{
        Tariffs = Tariffs.OrderBy(Tariff => Tariff.Price).ToList();
	}

	public void SortByPriceDescending()
	{
		this.SortByPriceAscending();
		Tariffs.Reverse();
	}

	public Communications SortByName()
	{
        return new Communications(Tariffs.OrderBy(Tariff => Tariff.Name).ToList());
    }

    public void PrintTariffs()
	{
		Console.WriteLine("┌────────────────────┬──────────┬──────────┬──────────┬───────────────┐\n" +
			"│{0,-20}│{1,-10}│{2,-10}│{3,-10}│{4,-15}│", "Name","Internet","Minutes","Price","Clients");
		Console.WriteLine("├────────────────────┼──────────┼──────────┼──────────┼───────────────┤");
		foreach(Tariff Tariff in Tariffs)
		{
			Console.WriteLine(Tariff.ToString());
		}
        Console.WriteLine("└────────────────────┴──────────┴──────────┴──────────┴───────────────┘");
    }

	public Communications TariffsByPrice(int MinPrice, int MaxPrice)
	{
		return new Communications(Tariffs.Where(Tariff => Tariff.Price >= MinPrice && Tariff.Price <= MaxPrice).ToList());
    }

    public Communications TariffsByInternet(int MinInternet)
    {
        return new Communications(Tariffs.Where(Tariff => Tariff.Internet >= MinInternet || Tariff.Internet == -1).ToList());
    }

    public Communications TariffsByMinutes(int MinMinutes)
    {
        return new Communications(Tariffs.Where(Tariff => Tariff.Minutes >= MinMinutes).ToList());
    }

}