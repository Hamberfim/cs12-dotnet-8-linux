// call the functions in Program.Functions.cs
TimesTable(7, 15); // parameters (byte number, byte? size) byte =0-255

// set console config to culture
ConfigConsole();
// ConfigConsole("fr-FR");  // set it to France

decimal myAmount = 149.99m;
decimal taxToPay = CalculateVatTax(amount: myAmount, regionCode: "FR");
WriteLine($"In France you would pay {taxToPay:C2} tax on {myAmount:C2}");

taxToPay = CalculateVatTax(amount: myAmount, regionCode: "CH");
WriteLine($"In Switzerland you would pay {taxToPay:C2} tax on {myAmount:C2}");

taxToPay = CalculateVatTax(amount: myAmount, regionCode: "HU");
WriteLine($"In Hungary you would pay {taxToPay:C2} tax on {myAmount:C2}");

// interpolation within Writeline() output
WriteLine($"In Norway you would pay {CalculateVatTax(amount: myAmount, regionCode: "NO"):C2} tax on {myAmount:C2}");

taxToPay = CalculateVatTax(amount: myAmount, regionCode: "");
WriteLine($"In most of the U.S you would pay {taxToPay:C2} tax on {myAmount:C2}");