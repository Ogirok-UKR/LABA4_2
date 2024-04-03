public class Turbo : SuperNet
{
    public int Internet = -1;
    public string AdditionalFeatures { get; private set; } = "Підтримується eSim";
    public int InternetInRouming { get; set; }
    


    public Turbo(string Type, int Minutes, int Price, int NumberNumberOfClients)
        : base(Type, -1, Minutes, Price, NumberNumberOfClients) { }
    public Turbo(string Type, int Minutes, int Price, int NumberNumberOfClients, string AdditionalFeatures)
        : base(Type, -1, Minutes, Price, NumberNumberOfClients, AdditionalFeatures) { }
    public Turbo(string Type, int Minutes, int MinutesInRouming, int InternetInRouming, int Price, int NumberNumberOfClients)
        : base(Type, -1, Minutes, Price, NumberNumberOfClients) 
    {
        this.MinutesInRouming = MinutesInRouming;
        this.InternetInRouming = InternetInRouming;
    }

    public Turbo(string Type, int Internet, int Minutes, int MinutesInRouming, int InternetInRouming, int Price, int NumberNumberOfClients, string AdditionalFeatures)
        : base(Type, Internet, Minutes, Price, NumberNumberOfClients, AdditionalFeatures) 
    {
        this.MinutesInRouming = MinutesInRouming;
        this.InternetInRouming = InternetInRouming;
    }


    public override string ToString()
    {
        string internet = (Internet != -1) ? $"{Internet}GB" : "Unlimited";
        return string.Format("│ {0,-20}│ {1,-10}│ {2,-10}│ {3,-15}│{7,-5}│ {4,-10}│ {5,-15}│ {6,-40}│",
            "Turbo " + Type, internet, Minutes + " min", MinutesInRouming+"min "+InternetInRouming+"GB",Price + " UAH", NumberOfClients + " people", AdditionalFeatures," "+SMS);
    }

}