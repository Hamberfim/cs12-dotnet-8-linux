// var types review
char ltr = 'a';
char dgt = '1';
char symb = '$';
string name = "Bob Smith";
string ph = "(515) 555-5555";
string horzLn = new('-', count: 25); // using the string class constructor
Console.WriteLine("\n" + horzLn);

// Console.OutputEncoding = System.Text.Encoding.UTF8; -- for windows console
string smileEmoji = Char.ConvertFromUtf32(0x1F600);  // emoji converted from unicode
Console.WriteLine(smileEmoji + smileEmoji + smileEmoji);
Console.WriteLine(horzLn);

// verbatim strings
string wackyPath = @"C:\Bob$BitCoin\Wh@tARip0ff\Ca11\Th3\Aht0r1t13$";
Console.WriteLine(wackyPath);

// raw liter strings
string xmlCode = """
                    <person age="45">
                        <name>Bill Smith</name>
                    </person>
                 """;
Console.WriteLine(xmlCode);

// interpolation string literals -- beats the hell out of formatting in Java
var personObj = new { fName = "Bill", age = 45 };
string json = $$"""
                {
                    "fName": "{{personObj.fName}}",
                    "age": "{{personObj.age}}"
                    "Age +1+": "{{{personObj.age + 1}}}" 
                }
              """;
Console.WriteLine(json);
Console.WriteLine($"Name: {name}, Phone: {ph}");

uint naturalNum = 128;
int signedInt = -128;
float realNum = 2.333f;
double morePrecRealNum = 2.333;
int numNotation = 2_000_000;
Console.WriteLine($"{numNotation:N0}");
Console.WriteLine($"{numNotation:N2}");

// float, double and decimal type accuracy
float a1 = 0.1f;
float b1 = 0.2f;
if (a1 + b1 == 0.3f)
{
    Console.WriteLine($"{a1} + {b1} = {0.3f}");
}
else
{
    Console.WriteLine($"{a1} + {b1} != {0.3f}");
}

double a2 = 0.1;
double b2 = 0.2;
if (a2 + b2 == 0.3)
{
    Console.WriteLine($"{a2} + {b2} = {0.3}");
}
else
{
    Console.WriteLine($"{a2} + {b2} != {0.3}");
}

decimal a3 = 0.1M;
decimal b3 = 0.2M;
if (a3 + b3 == 0.3M)
{
    Console.WriteLine($"{a3} + {b3} = {0.3M}");
}
else
{
    Console.WriteLine($"{a3} + {b3} != {0.3M}");
}

// dynamic data types 
dynamic anyType;
anyType = new[] { 1, 2, 3, 4 };
// let compiler infer the type
var anyTypeType = Convert.ToString(Type.GetTypeCode(anyType.GetType()));
int isLength = (anyTypeType == "Int32") ? 0 : anyType.Length;
Console.WriteLine($"Dynamic var 'anyType' is a {anyType.GetType()} and has {isLength} length.");

anyType = "Bill Smith";
anyTypeType = Convert.ToString(Type.GetTypeCode(anyType.GetType()));
isLength = (anyTypeType == "Int32") ? 0 : anyType.Length;
Console.WriteLine($"Dynamic var 'anyType' is a {anyType.GetType()} and has {isLength} length.");

anyType = -128;
anyTypeType = Convert.ToString(Type.GetTypeCode(anyType.GetType()));
isLength = (anyTypeType == "Int32") ? 0 : anyType.Length;
Console.WriteLine($"Dynamic var 'anyType' is a {anyType.GetType()} and has {isLength} length.");
