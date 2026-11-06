
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared30685e6067cce163), TypeInfoPropertyName = "AutoSDKShared30685e6067cce1632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared30685e6067cce163Variant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared30685e6067cce163Variant1Development))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedaffe019c1a64bb83))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared8497046ac346003c))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedb2aa6c85fab0cd65))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared30685e6067cce163>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedaffe019c1a64bb83Development))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedaffe019c1a64bb83RoutingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedaffe019c1a64bb83RoutingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedb2aa6c85fab0cd65Options))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedb2aa6c85fab0cd65Version), TypeInfoPropertyName = "AutoSDKSharedb2aa6c85fab0cd65Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateMicrofrontendsGroupWithApplicationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateMicrofrontendsGroupWithApplicationsRequestDefaultApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.CreateMicrofrontendsGroupWithApplicationsRequestOtherApplication>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateMicrofrontendsGroupWithApplicationsRequestOtherApplication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetMicrofrontendsInGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateMicrofrontendsGroupWithApplicationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateMicrofrontendsGroupWithApplicationsResponseNewMicrofrontendsGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared30685e6067cce163?), TypeInfoPropertyName = "NullableAutoSDKShared30685e6067cce1632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedb2aa6c85fab0cd65Version?), TypeInfoPropertyName = "NullableAutoSDKSharedb2aa6c85fab0cd65Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKSharedaffe019c1a64bb83RoutingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateMicrofrontendsGroupWithApplicationsRequestOtherApplication>))]
    internal sealed partial class MicrofrontendsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MicrofrontendsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static MicrofrontendsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private MicrofrontendsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            global::Vercel.PartitionCoreSourceGenerationContext.AddConverters(options);
            options.Converters.Add(new global::Vercel.JsonConverters.AutoSDKShared30685e6067cce163JsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Vercel.AutoSDKSharedb2aa6c85fab0cd65Version)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedb2aa6c85fab0cd65Version?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedb2aa6c85fab0cd65Version))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedb2aa6c85fab0cd65VersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedb2aa6c85fab0cd65Version?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedb2aa6c85fab0cd65VersionNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new MicrofrontendsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::Vercel.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}