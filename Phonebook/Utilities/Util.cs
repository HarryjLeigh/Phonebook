namespace Phonebook.Utilities;

public static class Util
{
    internal static void AskUserToContinue()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}