namespace AboutMyEnv;

class Program
{
    static void Main(string[] args)
    {
        // creating a region
        #region how to display info about your environment

        Console.WriteLine(Environment.CurrentDirectory);
        Console.WriteLine(Environment.OSVersion.VersionString);
        Console.WriteLine($"Namespace: {typeof(Program).Namespace}");

        #endregion
    }
}
