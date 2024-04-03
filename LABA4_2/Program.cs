System.Console.OutputEncoding = System.Text.Encoding.Unicode;

Communications Vodafone = new Communications(new List<Tariff>
{
    new Tariff("Base",20,600,120,53267),
    new Joice("Start", 25, 800, 180, 1488),
    new Joice("Pro", 35, 1200, 230, 4308),
    new Joice("Max", 50, 1600, 300, 1917),
    new SuperNet("Start", 25, 200, 30, 200, 1324),
    new SuperNet("Pro", 45, 300, 60, 280, 3037),
    new SuperNet("Turbo", -1, 800, 120, 190, 931),
    new SuperNet("Unlim", -1, 400, 180, 410, 857),
    new Turbo("Start", 1600, 30, 20, 165, 2024),
    new Turbo("Pro", 1600, 60,40,220, 891),
}
);

Vodafone.PrintTariffs();
Console.WriteLine("Після сортування за ціною");
Vodafone.OrderByPriceAscending().PrintTariffs();
Console.WriteLine("Шукаємо тариф від 200грн до 400грн");
Vodafone.SortByPrice(200,400).PrintTariffs();

