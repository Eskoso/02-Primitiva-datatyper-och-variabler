using Spectre.Console;
using SDColor = System.Drawing.Color;

Console.Clear();

AnsiConsole.Write(
    new FigletText("CHATBOT")
        .Centered()
        .Color(Color.Cyan1)
);

AnsiConsole.MarkupLine("[grey]Skriv 'exit' för att avsluta chatten.[/]");
AnsiConsole.WriteLine();

while (true)
{
    string message = AnsiConsole.Ask<string>("[bold cyan]Du >[/]");

    string botResponse = "";

    if (message.ToLower() == "exit")
        break;

    if (message.ToLower() == "help")
    {
        botResponse = "[grey]Tillgängliga kommandon:[/]" + Environment.NewLine +
                      "[cyan]exit[/] - Avsluta chatten." + Environment.NewLine +
                      "[cyan]help[/] - Visa alla kommandon." + Environment.NewLine +
                      "[cyan]hej[/] - Visa ett välkomstmeddelande." + Environment.NewLine +
                      "[cyan]devsecops[/] - Information om DevSecOps." + Environment.NewLine +
                      "[cyan]säkerhet[/] - Information om IT-säkerhet." + Environment.NewLine +
                      "[cyan]programmering[/] - Information om programmering." + Environment.NewLine +
                      "[cyan]csharp[/] - Information om C#." + Environment.NewLine +
                      "[cyan]datum[/] - Visa dagens datum." + Environment.NewLine +
                      "[cyan]tid[/] - Visa aktuell tid." + Environment.NewLine +
                      "[cyan]clear[/] - Rensa chatten.";
    }
    else if (message.ToLower() == "hej")
    {
        botResponse = "[grey]Hejsan! Vad kul att du är här! Skriv [cyan]help[/] för att se vilka kommandon som finns tillgängliga.[/]";
    }
    else if (message.ToLower() == "devsecops")
    {
        botResponse = "[grey]DevSecOps är en metodik som integrerar säkerhet i hela mjukvaruutvecklingen. Målet är att säkerhet ska vara en naturlig del av processen från utveckling och testning till driftsättning och underhåll, istället för något som läggs till i efterhand.[/]";
    }
    else if (message.ToLower() == "säkerhet")
    {
        botResponse = "[grey]IT-säkerhet handlar om att skydda system, nätverk och information mot obehörig åtkomst, attacker och andra säkerhetshot.[/]";
    }
    else if (message.ToLower() == "programmering")
    {
        botResponse = "[grey]Programmering innebär att skriva instruktioner som talar om för en dator vad den ska göra. Exempel på programmeringsspråk är C#, JavaScript och Python.[/]";
    }
    else if (message.ToLower() == "csharp")
    {
        botResponse = "[grey]C# är ett programmeringsspråk utvecklat av Microsoft och används bland annat för webbapplikationer, spel, desktopprogram och backendutveckling.[/]";
    }
    else if (message.ToLower() == "datum")
    {
        botResponse = $"[grey]Dagens datum är [cyan]{DateTime.Now:yyyy-MM-dd}[/].[/]";
    }
    else if (message.ToLower() == "tid")
    {
        botResponse = $"[grey]Klockan är [cyan]{DateTime.Now:HH:mm:ss}[/].[/]";
    }
    else if (message.ToLower() == "clear")
    {
        Console.Clear();

        AnsiConsole.Write(
            new FigletText("CHATBOT")
                .Centered()
                .Color(Color.Cyan1)
        );

        AnsiConsole.MarkupLine("[grey]Skriv 'exit' för att avsluta chatten.[/]");
        AnsiConsole.WriteLine();

        continue;
    }
    else
    {
        botResponse = "[grey]Jag är ledsen, jag förstår inte. Skriv [cyan]help[/] för att se tillgängliga kommandon.[/]";
    }


    var responsePanel = new Panel(
        new Markup($"[white]{botResponse}[/]")
    )
    {
        Header = new PanelHeader("[bold green] Chatbot [/]")
    };

    responsePanel.Border = BoxBorder.Rounded;

    AnsiConsole.Write(responsePanel);
    AnsiConsole.WriteLine();
}

AnsiConsole.MarkupLine("[grey]Chatten avslutades.[/]");