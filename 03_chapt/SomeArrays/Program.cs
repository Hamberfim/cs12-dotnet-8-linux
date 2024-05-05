#region array reminders 
// single dimension
string[] names;
names = new string[3];
names[0] = "Tom";
names[1] = "Tina";
names[2] = "Larry";

WriteLine("Single Array");
foreach (string name in names)
{
    WriteLine(name);
}

WriteLine("\nSingle Array");
// declare inline
double[] prices = { 1.99, 2.99, 4.99 };
foreach (double price in prices)
{
    WriteLine(price);
}

// multidimensional
string[,] twoDgrid = {
    {"0-0", "0-1"},
    {"0-1", "1-1" },
    {"0-2", "2-1" },
};

WriteLine("\n2D Array");
for (int i = 0; i < twoDgrid.GetLength(0); i++)
{
    for (int j = 0; j < twoDgrid.GetLength(1); j++)
    {
        Write(twoDgrid[i, j] + " ");
    }
    WriteLine();
}



// jagged array
string[][] jaggedArr = {
    new[] {"0-0", "0-1", "0-2"},
    new[] {"1-0", "1-1", "1-2", "1-3"},
    new[] {"2-0", "2-1", "2-2", "2-3"},
    new[] {"3-0", "3-1"},
};

WriteLine("\nJagged Array");
for (int i = 0; i < jaggedArr.Length; i++)
{
    for (int j = 0; j < jaggedArr[i].Length; j++)
    {
        Write(jaggedArr[i][j] + " ");
    }
    WriteLine();
}


#endregion