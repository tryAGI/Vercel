using System.Text.Json;

namespace Vercel;

internal static class SerializationSmoke
{
    internal static void Run()
    {
        var request = CreateProjectRequest.FromJson("""
            {"name":"offline-smoke","enablePreviewFeedback":false,"framework":"nextjs",
             "environmentVariables":[{"key":"EXAMPLE","value":"non-secret","target":"preview"}]}
            """) ?? throw new InvalidOperationException("Request deserialization failed.");
        using (var json = JsonDocument.Parse(request.ToJson()))
        {
            Require(json.RootElement.GetProperty("name").GetString() == "offline-smoke", "Request name");
            Require(!json.RootElement.GetProperty("enablePreviewFeedback").GetBoolean(), "Nullable false boolean");
            Require(json.RootElement.GetProperty("framework").GetString() == "nextjs", "Nullable enum");
            Require(json.RootElement.GetProperty("environmentVariables")[0].GetProperty("target").GetString() == "preview", "Union scalar");
        }
        var variable = CreateProjectRequestEnvironmentVariable.FromJson("""
            {"key":"EXAMPLE","value":"non-secret","target":["preview","production"]}
            """) ?? throw new InvalidOperationException("Union deserialization failed.");
        using (var json = JsonDocument.Parse(variable.ToJson()))
        {
            Require(json.RootElement.GetProperty("target").GetArrayLength() == 2, "Union array");
            Require(json.RootElement.GetProperty("target")[1].GetString() == "production", "Union array enum");
        }
        var response = UpdateSharedEnvVariableResponse.FromJson("""
            {"failed":[],"updated":[],"extra":{"nested":[null,false,42,"text"]}}
            """) ?? throw new InvalidOperationException("Response deserialization failed.");
        using (var json = JsonDocument.Parse(response.ToJson()))
        {
            Require(json.RootElement.GetProperty("failed").GetArrayLength() == 0, "Response empty list");
            var nested = json.RootElement.GetProperty("extra").GetProperty("nested");
            Require(nested[0].ValueKind == JsonValueKind.Null && !nested[1].GetBoolean() &&
                    nested[2].GetInt32() == 42 && nested[3].GetString() == "text", "Dynamic extension data graph");
        }

    }

    private static void Require(bool condition, string description)
    {
        if (!condition) throw new InvalidOperationException($"JSON contract failed: {description}");
    }
}
