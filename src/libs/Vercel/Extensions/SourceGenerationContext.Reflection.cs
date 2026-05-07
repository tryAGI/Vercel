#nullable enable

using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Vercel;

/// <summary>
/// Reflection-backed serializer context for the Vercel SDK.
/// </summary>
public sealed class SourceGenerationContext : JsonSerializerContext
{
    [UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Vercel's generated OpenAPI model graph currently exceeds source-generation limits; this fallback preserves buildability until the spec can be narrowed.")]
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
    [UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Vercel's generated OpenAPI model graph currently exceeds source-generation limits; this fallback preserves buildability until the spec can be narrowed.")]
    public SourceGenerationContext(JsonSerializerOptions? options)
        : base(options ?? CreateDefaultOptions())
    {
        Options.TypeInfoResolver ??= new DefaultJsonTypeInfoResolver();
    }

    /// <inheritdoc />
    protected override JsonSerializerOptions? GeneratedSerializerOptions => Options;

    /// <inheritdoc />
    [UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Vercel's generated OpenAPI model graph currently exceeds source-generation limits; this fallback preserves buildability until the spec can be narrowed.")]
    public override JsonTypeInfo? GetTypeInfo(Type type)
    {
        ArgumentNullException.ThrowIfNull(type);

        return Options.GetTypeInfo(type);
    }
}
