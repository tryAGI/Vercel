namespace Vercel.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static VercelClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("VERCEL_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("VERCEL_API_KEY environment variable is not found.");

        var client = new VercelClient(apiKey);
        
        return client;
    }
}
