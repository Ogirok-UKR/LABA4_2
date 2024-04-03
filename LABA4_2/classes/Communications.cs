using System;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

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

	public void RemoveTariff(int index)
	{
		Tariffs.RemoveAt(index);
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

	public Communications OrderByPriceAscending()
	{
        return new Communications(Tariffs.OrderBy(Tariff => Tariff.Price).ToList());
	}

	public Communications OrderByPriceDescending()
	{
        return new Communications(Tariffs.OrderBy(Tariff => Tariff.Price).Reverse().ToList());
    }

	public Communications OrderByType()
	{
        return new Communications(Tariffs.OrderBy(Tariff => Tariff.Type).ToList());
    }

    public void PrintTariffs()
	{
		Console.WriteLine("┌─────────────────────┬───────────┬───────────┬────────────────┬─────┬───────────┬────────────────┬─────────────────────────────────────────┐\n" +
            "│ {0,-20}│ {1,-10}│ {2,-10}│ {3,-15}│{7,-5}│ {4,-10}│ {5,-15}│ {6,-40}│", "Name","Internet","Minutes","Rouming","Price","Clients", "Additional Features"," SMS");
		Console.WriteLine("├─────────────────────┼───────────┼───────────┼────────────────┼─────┼───────────┼────────────────┼─────────────────────────────────────────┤");
		foreach(Tariff Tariff in Tariffs)
		{
			Console.WriteLine(Tariff.ToString());
		}
        Console.WriteLine("└─────────────────────┴───────────┴───────────┴────────────────┴─────┴───────────┴────────────────┴─────────────────────────────────────────┘");
    }

	public Communications SortByPrice(int MinPrice, int MaxPrice)
	{
		return new Communications(Tariffs.Where(Tariff => Tariff.Price >= MinPrice && Tariff.Price <= MaxPrice).ToList());
    }

    public Communications SortByInternet(int MinInternet)
    {
        return new Communications(Tariffs.Where(Tariff => Tariff.Internet >= MinInternet || Tariff.Internet == -1).ToList());
    }

    public Communications SortByMinutes(int MinMinutes)
    {
        return new Communications(Tariffs.Where(Tariff => Tariff.Minutes >= MinMinutes).ToList());
    }

}