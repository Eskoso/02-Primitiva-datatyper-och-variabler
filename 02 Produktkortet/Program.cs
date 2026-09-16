using Spectre.Console;

// ========================
// PRODUKTDATA
// ========================

string[] productName = { "Logitech G Pro X Superlight", "Razer Ornata V3", "SteelSeries Rival 3" };
decimal[] price = { 1299.90m, 1049.90m, 1999.90m };
int[] stockAmount = { 6, 0, 10 };
bool[] inStock = { true, false, true };


// ========================
// HEADER
// ========================

AnsiConsole.Write(
    new FigletText("WEBSHOP")
        .Centered()
        .Color(Spectre.Console.Color.Cyan1)
);

AnsiConsole.Write(
    new Spectre.Console.Rule("[cyan]Produkter[/]")
        .RuleStyle("grey")
);


// ========================
// PRODUKTKORT
// ========================

for (int i = 0; i < productName.Length; i++)
{
    var productTable = new Table()
        .Border(TableBorder.Rounded)
        .BorderColor(Spectre.Console.Color.Grey);

    productTable.AddColumn("[grey]Egenskap[/]");
    productTable.AddColumn("[white]Information[/]");

    productTable.AddRow("[cyan]Produkt[/]", productName[i]);
    productTable.AddRow("[cyan]Pris[/]", $"{price[i]:C}");
    productTable.AddRow("[cyan]Antal i lager[/]", stockAmount[i].ToString());

    if (inStock[i])
    {
        productTable.AddRow(
            "[cyan]Lagerstatus[/]",
            "[green]Finns i lager[/]"
        );
    }
    else
    {
        productTable.AddRow(
            "[cyan]Lagerstatus[/]",
            "[red]Slut i lager[/]"
        );
    }

    // ========================
    // VISA PRODUKT
    // ========================

    AnsiConsole.Write(productTable);

    AnsiConsole.WriteLine();
}

AnsiConsole.Write(
    new Spectre.Console.Rule("[grey]Webshop[/]")
        .RuleStyle("grey")
);

Console.ReadKey();