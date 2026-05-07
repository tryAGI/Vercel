#nullable enable

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Vercel;

/// <summary>
/// Reflection-backed serializer context for the Vercel SDK.
/// </summary>
public sealed class SourceGenerationContext : JsonSerializerContext
{
    private static JsonSerializerOptions CreateDefaultOptions()
    {
        var options = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            TypeInfoResolver = new DefaultJsonTypeInfoResolver(),
        };

        return options;
    }

    /// <summary>
    /// Default serializer context used by generated clients.
    /// </summary>
    public static SourceGenerationContext Default { get; } = new(CreateDefaultOptions());

    /// <summary>
    /// Creates a serializer context with default options.
    /// </summary>
    public SourceGenerationContext()
        : this(CreateDefaultOptions())
    {
    }

    /// <summary>
    /// Creates a serializer context with custom options.
    /// </summary>
    public SourceGenerationContext(JsonSerializerOptions? options)
        : base(options ?? CreateDefaultOptions())
    {
        Options.TypeInfoResolver ??= new DefaultJsonTypeInfoResolver();
    }

    /// <inheritdoc />
    protected override JsonSerializerOptions? GeneratedSerializerOptions => Options;

    /// <inheritdoc />
    public override JsonTypeInfo? GetTypeInfo(Type type)
    {
        ArgumentNullException.ThrowIfNull(type);

        return Options.GetTypeInfo(type);
    }
}
