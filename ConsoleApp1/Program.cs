Console.WriteLine("Geef je familienaam");
string familienaam = Console.ReadLine();

Console.WriteLine("Geef je telefoonnummer ");
string telefoonnummer = Console.ReadLine();

Console.WriteLine("Geef je postcode ");
string postcode = Console.ReadLine();

string familienaamGroot = Convert.ToString(char.ToUpper(familienaam[0]));
string familienaamKlein = Convert.ToString(char.ToLower(familienaam[1]));

string zonenummer = Convert.ToString(telefoonnummer.Substring(1, 3));

double postgetal = Convert.ToDouble(postcode.Substring(0, 1));

double postKwadraat = Math.Pow(postgetal, 2);
Console.WriteLine();
Console.WriteLine("Password: " + familienaamKlein + familienaamGroot + zonenummer + postKwadraat);