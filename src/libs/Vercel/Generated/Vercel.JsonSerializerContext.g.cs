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
    private readonly JsonSerializerContext[] _contexts;

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
        _contexts =
        [
            new global::Vercel.SourceGenerationContextChunk000(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk001(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk002(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk003(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk004(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk005(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk006(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk007(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk008(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk009(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk010(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk011(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk012(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk013(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk014(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk015(CreateChildOptions(Options)),
            new global::Vercel.SourceGenerationContextChunk016(CreateChildOptions(Options))
        ];
    }

    /// <inheritdoc />
    protected override JsonSerializerOptions? GeneratedSerializerOptions => Options;

    /// <inheritdoc />
    public override JsonTypeInfo? GetTypeInfo(Type type)
    {
        ArgumentNullException.ThrowIfNull(type);

        foreach (var context in _contexts)
        {
            var typeInfo = context.GetTypeInfo(type);
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

    private static JsonSerializerOptions CreateChildOptions(JsonSerializerOptions options)
    {
        return new JsonSerializerOptions(options);
    }
}
