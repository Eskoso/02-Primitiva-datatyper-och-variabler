using Spectre.Console;

Console.Clear();

// ========================
// PERSONDATA
// ========================

string firstName = "John";
string lastName = "Doe";
int age = 24;

string city = "Katrineholm";
string address = "adressvägen 13";
string postalCode = "64578";

string phone = "070-123 45 67";
string email = "john.doe@email.com";


// ========================
// HEADER
// ========================

AnsiConsole.Write(
    new FigletText("PERSONINFO")
        .Centered()
        .Color(Color.Cyan1)
);

AnsiConsole.Write(
    new Rule("[cyan]Personöversikt[/]")
        .RuleStyle("grey")
);


// ========================
// GRUNDINFORMATION
// ========================

var personalInfo = new Table()
    .Border(TableBorder.Rounded)
    .BorderColor(Color.Grey);

personalInfo.AddColumn("[grey]Person[/]");
personalInfo.AddColumn("[white]Information[/]");

personalInfo.AddRow("[cyan]Namn[/]", $"{firstName} {lastName}");
personalInfo.AddRow("[cyan]Ålder[/]", age.ToString());
personalInfo.AddRow("[cyan]Hemort[/]", city);

AnsiConsole.Write(
    new Panel(personalInfo)
        .Header("[bold cyan] PERSONUPPGIFTER [/]")
        .Border(BoxBorder.Rounded)
        .Padding(1, 1)
);


// ========================
// ADRESS
// ========================

var addressInfo = new Table()
    .Border(TableBorder.Simple);

addressInfo.AddColumn("Adress");
addressInfo.AddColumn("Information");

addressInfo.AddRow("Adress", address);
addressInfo.AddRow("Postnummer", postalCode);
addressInfo.AddRow("Ort", city);

AnsiConsole.Write(
    new Panel(addressInfo)
        .Header("[bold yellow] ADRESS [/]")
        .Border(BoxBorder.Rounded)
);


// ========================
// KONTAKT
// ========================

var contactInfo = new Table()
    .Border(TableBorder.Simple);

contactInfo.AddColumn("Kontakt");
contactInfo.AddColumn("Information");

contactInfo.AddRow("Telefon", phone);
contactInfo.AddRow("E-post", email);

AnsiConsole.Write(
    new Panel(contactInfo)
        .Header("[bold green] KONTAKT [/]")
        .Border(BoxBorder.Rounded)
);


// ========================
// FOOTER
// ========================

AnsiConsole.Write(
    new Rule("[grey]Slut på personinformation, klicka på någon tangent för att avsluta...[/]")
        .RuleStyle("grey")
);

Console.ReadKey();