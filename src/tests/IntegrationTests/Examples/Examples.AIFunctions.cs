using tryAGI.Vercel;

namespace Vercel.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AIFunctions()
    {
        //// Use Vercel tools with any MEAI-compatible AI provider
        using var client = new VercelClient(apiKey: "test");
        var tools = client.AsTools();
        tools.Count.Should().BeGreaterThan(0);
    }
}
