using System.Reflection;  // To use Assembly, TypeName,etc.

// declare some var using types in additional assemblies to make them load too.
System.Data.DataSet ds = new();
HttpClient client = new();

/*This program will show C# types and their methods*/
// get the assembly that is the entry point of this app
Assembly? myApp = Assembly.GetEntryAssembly();

// if the above line returned nothing, end the app
if (myApp is null) return;

// loop thru the assemblies that myApp references
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // load assembly so we can read its details
    Assembly a = Assembly.Load(name);

    // var to count the number of methods
    int methodCount = 0;

    // loop thru all the types in the assembly
    foreach (TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Length;
    }

    // output the count of types and their methods
    Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", arg0: a.DefinedTypes.Count(), arg1: methodCount, arg2: name.Name);

}