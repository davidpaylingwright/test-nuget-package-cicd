namespace TestNugetPackageCICD;

public static class Configuration
{
    public const string GREETING = "Hello";

    public static Func<string, string> GetMessage => (name) => $"{GREETING}, {name}";
}
