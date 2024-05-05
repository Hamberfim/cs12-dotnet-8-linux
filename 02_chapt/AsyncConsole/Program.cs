// client instance of Http
HttpClient client = new();

// make a request
HttpResponseMessage res = await client.GetAsync("https://www.apple.com");
// output how many bytes it has 
WriteLine($"Apple's home page has {res.Content.Headers.ContentLength} bytes.");

// make a request
res = await client.GetAsync("https://www.microsoft.com");
// output how many bytes it has 
WriteLine($"Microsoft's home page has {res.Content.Headers.ContentLength} bytes.");

// make a request
res = await client.GetAsync("https://www.cnn.com");
// output how many bytes it has 
WriteLine($"CNN's home page has {res.Content.Headers.ContentLength} bytes.");

