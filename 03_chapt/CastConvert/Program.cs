using static System.Convert;  // convert methods
using System.Globalization;  // CultureInfo

#region quite casting/conversion review

int a = 10;
// implicit
double b = a;
WriteLine($"a is {a}, b is {b:N1}");

double c = 9.5;
// explicit
int d = (int)c;
WriteLine($"c is {c}, d is {d}");

int e = ToInt32(c);  // rounding based
WriteLine($"c is {c}, e is {e}");

double f = 9.3;
int g = ToInt32(f);  // rounding based
WriteLine($"f is {f}, g is {g}");

// any type to string
double pi = 3.14;
WriteLine(pi.ToString());

bool isTrue = true;
WriteLine(isTrue.ToString());

DateTime now = DateTime.Now;
WriteLine(now.ToString());

object obj = new();
WriteLine(obj.ToString());

// parse back
// set current culture
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
int count = int.Parse("58");
DateTime dob = DateTime.Parse("3 April 1966");
WriteLine($"I am {count} and I was born on {dob:f}.");

#endregion