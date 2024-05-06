// call the functions in Program.Functions.cs

TimesTable(7, 10); // parameters (byte number, byte? size) byte = 0-255
TimesTable(10, 10); // parameters (byte number, byte? size) byte = 0-255

// set console config to culture
ConfigConsole();  // whatever the default is that is set in the Program.Functions.cs
// ConfigConsole("fr-FR");  // Example: to set it to France
WriteLine("=================================================");

decimal myAmount = 149.99m;
// regionCode: "FR" overrides whats set in Program.Functions.cs
decimal taxToPay = CalculateVatTax(amount: myAmount, regionCode: "FR");
WriteLine($"In France you would pay {taxToPay:C2} tax on {myAmount:C2}");

// regionCode: "CH" overrides whats set in Program.Functions.cs
taxToPay = CalculateVatTax(amount: myAmount, regionCode: "CH");
WriteLine($"In Switzerland you would pay {taxToPay:C2} tax on {myAmount:C2}");

taxToPay = CalculateVatTax(amount: myAmount, regionCode: "HU");
WriteLine($"In Hungary you would pay {taxToPay:C2} tax on {myAmount:C2}");

// interpolation within Writeline() output
WriteLine($"In Denmark and Norway you would pay {CalculateVatTax(amount: myAmount, regionCode: "NO"):C2} tax on {myAmount:C2}");

taxToPay = CalculateVatTax(amount: myAmount, regionCode: "");
WriteLine($"In most of the U.S you would pay {taxToPay:C2} tax on {myAmount:C2}");

WriteLine("\n=================================================");
// "OR" or "AK" or "MT" => 0.0m, // Oregon/Alaska/Montana
taxToPay = CalculateVatTax(amount: myAmount, regionCode: "OR");
WriteLine($"But in U.S locations like Alaska, Montana and Oregon you would pay {taxToPay:C2} tax on {myAmount:C2} \nbecause they have no State tax.");

WriteLine("\n============= Cardinal To Ordinal ===================");
RunCardinalToOrdinal();

WriteLine("\n============= Factorial ===================");
RunFactorial();