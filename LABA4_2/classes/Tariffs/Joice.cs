public class Joice : Tariff
{
    public string AdditionalFeatures { get; private set; } = "Безліміт на інтернет в соц мережах";
    

    public Joice(string Type,int Internet, int Minutes, int Price, int NumberNumberOfClients)
        : base(Type, Internet, Minutes, Price, NumberNumberOfClients) { }

    public Joice(string Type, int Internet, int Minutes, int Price, int NumberNumberOfClients, string AdditionalFeatures)
        : base(Type, Internet, Minutes, Price, NumberNumberOfClients) { this.AdditionalFeatures = AdditionalFeatures; }

    public override string ToString()
    {
       return string.Format("│ {0,-20}│ {1,-10}│ {2,-10}│ {3,-15}│{7,-5}│ {4,-10}│ {5,-15}│ {6,-40}│",
           "Joice " + Type, Internet + "GB", Minutes + " min", "", Price + " UAH", NumberOfClients + " people",AdditionalFeatures,"");
    }
}