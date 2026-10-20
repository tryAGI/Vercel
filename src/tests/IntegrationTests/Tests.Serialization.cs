namespace Vercel.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void JsonContractsRoundTripWithoutNetwork() => SerializationSmoke.Run();

    [TestMethod]
    public void AllGeneratedClrTypesLoad()
    {
        // Includes compiler-generated nested types; catches the CLR per-type method limit.
        typeof(VercelClient).Assembly.GetTypes().Length.Should().BeGreaterThan(1000);
    }
}
