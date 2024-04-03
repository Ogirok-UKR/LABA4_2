using System;

public class Tariff
{
	public string Name { get; set; }
	public int Internet { get; set; }
	public int Minutes { get; set; }
	public int Price { get; set; }
	public int NumberOfClients { get; set; }

	public Tariff(string Name, int Internet, int Minutes, int Price, int NumberOfClients)
	{
		this.Name = Name;
		this.Internet = Internet;
		this.Minutes = Minutes;
		this.Price = Price;
		this.NumberOfClients = NumberOfClients;
	}

    public override string ToString()
    {
		string internet = (Internet != -1) ? $"{Internet}GB" : "Unlimited";
        return string.Format("│ {0,-20}│ {1,-10}│ {2,-10}│ {3,-10}│ {4,-15}│", Name, internet, Minutes + " min", Price + " UAH", NumberOfClients + " people");
    }
}