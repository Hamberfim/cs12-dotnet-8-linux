using CallStackExceptionHandlingLib;

WriteLine("In Main...");
Alpha();

void Alpha()
{
    WriteLine("In Alpha...");
    Beta();
}

void Beta()
{
    WriteLine("In Beta...");
    try
    {
        Processor.Gamma();
    }
    catch (Exception ex)
    {
        WriteLine($"Exception caught: {ex.Message}");
        throw;
    }
}