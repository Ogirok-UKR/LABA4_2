public class SuperNet : Joice
{
    public string AdditionalFeatures { get; private set; } = "Безліміт в мережі Vodafone";
    public int MinutesInRouming { get;  set; }

    public int SMS { get; set; } = 50;

    public SuperNet(string Type, int Internet, int Minutes, int Price, int NumberNumberOfClients)
        : base(Type, Internet, Minutes, Price, NumberNumberOfClients) { }
    public SuperNet(string Type, int Internet, int Minutes, int MinutesInRouming, int Price, int NumberNumberOfClients)
        : base(Type, Internet, Minutes, Price, NumberNumberOfClients) { this.MinutesInRouming = MinutesInRouming; }

    public SuperNet(string Type,int Internet, int Minutes, int Price, int NumberNumberOfClients, string AdditionalFeatures)
        : base(Type,Internet , Minutes, Price, NumberNumberOfClients, AdditionalFeatures) { }

    public SuperNet(string Type, int Internet, int Minutes, int MinutesInRouming, int Price, int NumberNumberOfClients, string AdditionalFeatures)
        : base(Type, Internet, Minutes, Price, NumberNumberOfClients, AdditionalFeatures) { this.MinutesInRouming = MinutesInRouming;}

    public override string ToString()
    {
        string internet = (Internet != -1) ? $"{Internet}GB" : "Unlimited";
        return string.Format("│ {0,-20}│ {1,-10}│ {2,-10}│ {3,-15}│{7,-5}│ {4,-10}│ {5,-15}│ {6,-40}│",
            "SuperNet " + Type, internet, Minutes + " min", MinutesInRouming + "min",Price + " UAH", NumberOfClients + " people", AdditionalFeatures," "+SMS);
    }
}