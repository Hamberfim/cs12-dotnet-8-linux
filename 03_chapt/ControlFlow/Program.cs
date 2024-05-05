#region unary operators

int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");

int c = 3;
int d = ++c;
WriteLine($"c is {c}, d is {d}");

#endregion

#region ternary operator - simplified if statement

string result = (5 > 3) ? "True" : "False";
WriteLine(result);
result = (5 < 3) ? "True" : "False";
WriteLine(result);

#endregion

#region combined assignment operators

double totalPrice = 6.00;
totalPrice += 10.99;
WriteLine($"{totalPrice:C2}");

totalPrice -= 0.49;
WriteLine($"{totalPrice:C2}");

totalPrice *= 3;
WriteLine($"{totalPrice:C2}");

totalPrice /= 2;
WriteLine($"{totalPrice:C2}");

#endregion

#region misc operators
// nameof sizeof
int someNumber = 50;
WriteLine($"The {nameof(someNumber)} variable uses {sizeof(int)} bytes of memory.");
char firstDigit = someNumber.ToString()[0];
// = assignment operator
// . member access operator
// () invocation operator
// [] index access operator
#endregion