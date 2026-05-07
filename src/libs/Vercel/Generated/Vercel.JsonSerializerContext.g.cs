#nullable enable

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Vercel;

/// <summary>
/// Source-generated serializer context used by generated Vercel clients.
/// </summary>
public sealed class SourceGenerationContext : JsonSerializerContext
{
    private readonly IJsonTypeInfoResolver[] _resolvers;

    /// <summary>
    /// Default serializer context instance.
    /// </summary>
    public static SourceGenerationContext Default { get; } = new();

    /// <summary>
    /// Creates a serializer context with the default generated options.
    /// </summary>
    public SourceGenerationContext()
        : this(CreateOptions())
    {
    }

    /// <summary>
    /// Creates a serializer context using the supplied options.
    /// </summary>
    public SourceGenerationContext(JsonSerializerOptions options)
        : base(options)
    {
        _resolvers =
        [
            new global::Vercel.SourceGenerationContextChunk000(Options),
            new global::Vercel.SourceGenerationContextChunk001(Options),
            new global::Vercel.SourceGenerationContextChunk002(Options),
            new global::Vercel.SourceGenerationContextChunk003(Options),
            new global::Vercel.SourceGenerationContextChunk004(Options),
            new global::Vercel.SourceGenerationContextChunk005(Options),
            new global::Vercel.SourceGenerationContextChunk006(Options),
            new global::Vercel.SourceGenerationContextChunk007(Options),
            new global::Vercel.SourceGenerationContextChunk008(Options),
            new global::Vercel.SourceGenerationContextChunk009(Options),
            new global::Vercel.SourceGenerationContextChunk010(Options),
            new global::Vercel.SourceGenerationContextChunk011(Options),
            new global::Vercel.SourceGenerationContextChunk012(Options),
            new global::Vercel.SourceGenerationContextChunk013(Options),
            new global::Vercel.SourceGenerationContextChunk014(Options),
            new global::Vercel.SourceGenerationContextChunk015(Options),
            new global::Vercel.SourceGenerationContextChunk016(Options)
        ];
    }

    /// <inheritdoc />
    protected override JsonSerializerOptions? GeneratedSerializerOptions => Options;

    /// <inheritdoc />
    public override JsonTypeInfo? GetTypeInfo(Type type)
    {
        ArgumentNullException.ThrowIfNull(type);

        foreach (var resolver in _resolvers)
        {
            var typeInfo = resolver.GetTypeInfo(type, Options);
            if (typeInfo is not null)
            {
                return typeInfo;
            }
        }

        return null;
    }

    private static JsonSerializerOptions CreateOptions()
    {
        return new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        };
    }
}
