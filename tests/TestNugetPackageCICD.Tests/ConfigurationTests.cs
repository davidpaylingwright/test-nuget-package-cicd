namespace TestNugetPackageCICD.Tests;

public class ConfigurationTests
{
    [Fact]
    [Trait("Category", "Configuration")]
    public void GetMessage()
    {
        var name = "Bob";

        Assert.Equal($"{Configuration.GREETING}, {name}", Configuration.GetMessage(name));
    }
}