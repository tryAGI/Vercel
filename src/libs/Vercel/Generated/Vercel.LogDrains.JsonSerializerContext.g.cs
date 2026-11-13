
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared2208dea57c17c8da))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConfigurableLogDrainRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateLogDrainRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConfigurableLogDrainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetConfigurableLogDrainResponseProjectsMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConfigurableLogDrainResponseProjectsMetadataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConfigurableLogDrainResponseProjectsMetadataItemFramework), TypeInfoPropertyName = "GetConfigurableLogDrainResponseProjectsMetadataItemFramework2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetAllLogDrainsResponseVariant1Item>, global::Vercel.AutoSDKSharedfc4bd5d7b0e51454>), TypeInfoPropertyName = "OneOfIListGetAllLogDrainsResponseVariant1ItemAutoSDKSharedfc4bd5d7b0e514542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetAllLogDrainsResponseVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetAllLogDrainsResponseVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetAllLogDrainsResponseVariant1ItemProjectsMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetAllLogDrainsResponseVariant1ItemProjectsMetadataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetAllLogDrainsResponseVariant1ItemProjectsMetadataItemFramework), TypeInfoPropertyName = "GetAllLogDrainsResponseVariant1ItemProjectsMetadataItemFramework2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2208dea57c17c8da>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConfigurableLogDrainResponseProjectsMetadataItemFramework?), TypeInfoPropertyName = "NullableGetConfigurableLogDrainResponseProjectsMetadataItemFramework2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetAllLogDrainsResponseVariant1Item>, global::Vercel.AutoSDKSharedfc4bd5d7b0e51454>?), TypeInfoPropertyName = "NullableOneOfIListGetAllLogDrainsResponseVariant1ItemAutoSDKSharedfc4bd5d7b0e514542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetAllLogDrainsResponseVariant1ItemProjectsMetadataItemFramework?), TypeInfoPropertyName = "NullableGetAllLogDrainsResponseVariant1ItemProjectsMetadataItemFramework2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetConfigurableLogDrainResponseProjectsMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.List<global::Vercel.GetAllLogDrainsResponseVariant1Item>, global::Vercel.AutoSDKSharedfc4bd5d7b0e51454>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetAllLogDrainsResponseVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetAllLogDrainsResponseVariant1ItemProjectsMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKShared2208dea57c17c8da>))]
    internal sealed partial class LogDrainsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LogDrainsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static LogDrainsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private LogDrainsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.GetAllLogDrainsResponseVariant1Item>, global::Vercel.AutoSDKSharedfc4bd5d7b0e51454>());
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
                    typeToConvert == typeof(global::Vercel.GetConfigurableLogDrainResponseProjectsMetadataItemFramework)

                    || typeToConvert == typeof(global::Vercel.GetConfigurableLogDrainResponseProjectsMetadataItemFramework?)

                    || typeToConvert == typeof(global::Vercel.GetAllLogDrainsResponseVariant1ItemProjectsMetadataItemFramework)

                    || typeToConvert == typeof(global::Vercel.GetAllLogDrainsResponseVariant1ItemProjectsMetadataItemFramework?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.GetConfigurableLogDrainResponseProjectsMetadataItemFramework))
                {
                    return new global::Vercel.JsonConverters.GetConfigurableLogDrainResponseProjectsMetadataItemFrameworkJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetConfigurableLogDrainResponseProjectsMetadataItemFramework?))
                {
                    return new global::Vercel.JsonConverters.GetConfigurableLogDrainResponseProjectsMetadataItemFrameworkNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetAllLogDrainsResponseVariant1ItemProjectsMetadataItemFramework))
                {
                    return new global::Vercel.JsonConverters.GetAllLogDrainsResponseVariant1ItemProjectsMetadataItemFrameworkJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetAllLogDrainsResponseVariant1ItemProjectsMetadataItemFramework?))
                {
                    return new global::Vercel.JsonConverters.GetAllLogDrainsResponseVariant1ItemProjectsMetadataItemFrameworkNullableJsonConverter();
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
                    0 => new LogDrainsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::Vercel.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}